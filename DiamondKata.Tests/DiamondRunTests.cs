using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace DiamondKata.Tests;

public class DiamondRunTests
{
    [Fact]
    public void when_told_to_run_with_A_will_return_A()
    {
        var result = Diamond.Run('A');
        Assert.Equal("A" + Environment.NewLine, result);
    }

    [Fact]
    public void when_told_to_run_with_B_will_return_correct_result()
    {
        var result = Diamond.Run('B');
        Assert.Equal(
            " A " + Environment.NewLine +
            "B B" + Environment.NewLine +
            " A " + Environment.NewLine, 
            result);
    }

    [Fact]
    public void when_told_to_run_with_C_will_return_correct_result()
    {
        var result = Diamond.Run('C');
        Assert.Equal(
            "  A  " + Environment.NewLine +
            " B B " + Environment.NewLine +
            "C   C" + Environment.NewLine +
            " B B " + Environment.NewLine +
            "  A  " + Environment.NewLine, 
            result);
    }

    [Fact]
    public void when_told_to_run_with_a_will_throw_ArbumentException()
    {
        
    }
}