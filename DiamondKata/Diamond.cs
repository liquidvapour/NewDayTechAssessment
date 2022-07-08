using System.Text;

namespace DiamondKata;

public static class Diamond
{
    private const int FirstCharacter = 'A';

    public static string Run(string s)
    {
        return s;
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

    public static string RenderLine(char character, int maxCharacterCount)
    {
        var line = new StringBuilder();
        for (int i = 0; i < maxCharacterCount; i++)
        {
            var columnIndex = GetColumnIndex(i, maxCharacterCount);
            line.Append(GetCharacterForColumn(character, columnIndex));
        }

        return line.ToString();
    }

    public static int GetColumnIndex(int i, int width)
    {
        return Math.Abs(i - width / 2);
    }

    public static char GetCharacterForColumn(char c, int i) => c - FirstCharacter == i ? c : ' ';
}