namespace DiamondKata.Tests;

public class DiamondAppTests
{
    [Fact]
    public void happy_path_will_work()
    {
        using var stringWriter = new StringWriter();
        var sut = new DiamondApp(stringWriter, new []{"A"});
        sut.Run();
        Assert.Equal("A\r\n", stringWriter.ToString());
    }
    
    [Fact]
    public void when_run_without_a_first_argument_will_throw_InvalidOperationException()
    {
        using var stringWriter = new StringWriter();
        var sut = new DiamondApp(stringWriter, Array.Empty<string>());
        var act = () => sut.Run();
        Assert.Throws<InvalidOperationException>(act);
    }

    
    [Fact]
    public void when_run_with_more_than_one_character_will_throw_InvalidOperationException()
    {
        using var stringWriter = new StringWriter();
        var sut = new DiamondApp(stringWriter, new []{"AB"});
        var act = () => sut.Run();
        Assert.Throws<InvalidOperationException>(act);
    }

    [Fact]
    public void when_run_with_a_non_capital_alpha_will_throw_InvalidOperationException()
    {
        using var stringWriter = new StringWriter();
        var sut = new DiamondApp(stringWriter, new []{"a"});
        var act = () => sut.Run();
        Assert.Throws<InvalidOperationException>(act);
    }
}