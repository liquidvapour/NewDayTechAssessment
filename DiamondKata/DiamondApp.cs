namespace DiamondKata;

public class DiamondApp
{
    private readonly TextWriter _output;
    private readonly string[] _args;

    public DiamondApp(TextWriter output, string[] args)
    {
        _output = output;
        _args = args;
    }

    public void Run()
    {
        ValidateArgs();

        _output.Write(Diamond.Run(_args[0][0]));
    }

    private void ValidateArgs()
    {
        if (_args.Length == 0)
        {
            throw new InvalidOperationException();
        }

        if (_args[0].Length > 1)
        {
            throw new InvalidOperationException("Must pass a single character A through Z.");
        }

        if (_args[0][0] < 'A' || _args[0][0] > 'Z')
        {
            throw new InvalidOperationException("Must pass a character A through Z.");
        }
    }
}