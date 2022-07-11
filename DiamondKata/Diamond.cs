using System.Text;

namespace DiamondKata;

public static class Diamond
{
    private const int FirstCharacter = 'A';

    public static string Run(char s)
    {
        var characters = GetCharacters(s);
        var width = GetWidthFrom(characters.Length);
        var sb = new StringBuilder();
        for (var i = 0; i < width; i++)
        {
            var x = GetRowIndex(i, width);
            sb.AppendLine(RenderLine(characters[x], width));
        }

        return sb.ToString();
    }

    public static string GetCharacters(char s)
    {
        var numberOfCharacters = (s - FirstCharacter) + 1;

        var result = new char[numberOfCharacters];
        for (var i = 0; i < numberOfCharacters; i++)
        {
            result[i] = (char)(FirstCharacter + i);
        }

        return new string(result);
    }

    public static string RenderLine(char character, int width) => new(GenerateLine(character, width).ToArray());

    public static int GetColumnIndex(int i, int width) => Math.Abs(i - width / 2);

    public static char GetCharacterForColumn(char c, int i) => c - FirstCharacter == i ? c : ' ';

    private static IEnumerable<char> GenerateLine(char character, int width)
    {
        for (var i = 0; i < width; i++)
        {
            var columnIndex = GetColumnIndex(i, width);
            yield return GetCharacterForColumn(character, columnIndex);
        }
    }

    public static int GetWidthFrom(int numberOfCharacters) => numberOfCharacters * 2 - 1;

    public static int GetRowIndex(int rowNumber, int width)
    {
        var halfWidth = width / 2;
        return halfWidth - Math.Abs(rowNumber - halfWidth);
    }
}