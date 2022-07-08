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
        throw new NotImplementedException();
    }

    public static char GetCharacterForColumn(char c, int i) => c - FirstCharacter == i ? c : ' ';
}