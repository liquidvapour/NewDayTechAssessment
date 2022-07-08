namespace DiamondKata.Tests;

public class DiamondTests
{
    [Fact]
    public void when_given_A_return_A()
    {
        var result = Diamond.Run("A");
        Assert.Equal("A", result);
    }
}