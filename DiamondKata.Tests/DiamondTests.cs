namespace DiamondKata.Tests;

public class DiamondTests
{
    [Fact]
    public void when_told_to_run_with_A_will_return_A()
    {
        var result = Diamond.Run("A");
        Assert.Equal("A", result);
    }
}