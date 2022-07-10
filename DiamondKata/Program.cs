using DiamondKata;


try
{
    new DiamondApp(Console.Out, args).Run();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
