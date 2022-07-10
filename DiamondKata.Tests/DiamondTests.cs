namespace DiamondKata.Tests;

public class DiamondTests
{
    [Fact]
    public void when_told_to_run_with_A_will_return_A()
    {
        var result = Diamond.Run('A');
        Assert.Equal("A\r\n", result);
    }

    [Fact]
    public void when_told_to_run_with_B_will_return_correct_result()
    {
        var result = Diamond.Run('B');
        Assert.Equal(@" A 
B B
 A 
", result);
    }

    [Fact]
    public void when_told_to_run_with_C_will_return_correct_result()
    {
        var result = Diamond.Run('C');
        Assert.Equal(@"  A  
 B B 
C   C
 B B 
  A  
", result);
    }

    [Fact]
    public void when_told_to_get_characters_with_B_will_return_AB()
    {
        var result = Diamond.GetCharacters('B');
        Assert.Equal("AB", result);
    }

    [Fact]
    public void when_told_to_get_characters_with_C_will_return_ABC()
    {
        var result = Diamond.GetCharacters('C');
        Assert.Equal("ABC", result);
    }

    [Fact]
    public void when_told_to_render_line_A_with_width_3_will_return_xAx()
    {
        var result = Diamond.RenderLine('A', 3);
        Assert.Equal(" A ", result);
    }
    [Fact]
    public void when_told_to_render_line_B_with_width_3_will_return_BxB()
    {
        var result = Diamond.RenderLine('B', 3);
        Assert.Equal("B B", result);
    }

    [Theory]
    [InlineData('A', 0, 'A')]
    [InlineData('B', 0, ' ')]
    [InlineData('B', 1, 'B')]
    [InlineData('B', 2, ' ')]
    [InlineData('C', 0, ' ')]
    [InlineData('C', 1, ' ')]
    [InlineData('C', 2, 'C')]
    [InlineData('C', 3, ' ')]
    public void when_told_to_get_char_for_c_with_len_for_index_will_return(char c, int index, char expected)
    {
        var result = Diamond.GetCharacterForColumn(c, index);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 1, 0)]
    [InlineData(0, 3, 1)]
    [InlineData(1, 3, 0)]
    [InlineData(2, 3, 1)]
    [InlineData(0, 5, 2)]
    [InlineData(1, 5, 1)]
    [InlineData(2, 5, 0)]
    [InlineData(3, 5, 1)]
    [InlineData(4, 5, 2)]
    public void when_told_to_GetColumnIndex(int i, int width, int expected)
    {
        var result = Diamond.GetColumnIndex(i, width);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 3)]
    [InlineData(3, 5)]
    public void when_told_to_GetWidth_for_numberOfCharacters_will_return_expectedWidthidth(
        int numberOfCharacters,
        int expectedWidth)
    {
        var width = Diamond.GetWidthFrom(numberOfCharacters);
        Assert.Equal(expectedWidth, width);
    }

    [Theory]
    [InlineData(0, 1, 0)]
    [InlineData(0, 2, 0)]
    [InlineData(1, 2, 1)]
    [InlineData(2, 2, 0)]
    [InlineData(0, 5, 0)]
    [InlineData(1, 5, 1)]
    [InlineData(2, 5, 2)]
    [InlineData(3, 5, 1)]
    [InlineData(4, 5, 0)]
    public void when_told_to_GetRowIndex_for_rowNumber_and_width_will_return_rowIndex(
        int rowNumber,
        int width,
        int expectedRowIndex)
    {
        var rowIndex = Diamond.GetRowIndex(rowNumber, width);
        Assert.Equal(expectedRowIndex, rowIndex);
    }
}