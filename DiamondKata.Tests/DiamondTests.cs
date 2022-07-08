namespace DiamondKata.Tests;

public class DiamondTests
{
    [Fact]
    public void when_told_to_run_with_A_will_return_A()
    {
        var result = Diamond.Run("A");
        Assert.Equal("A", result);
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
    public void when_told_to_render_line_A_with_max_length_3_will_return_xxAxx()
    {
        var result = Diamond.RenderLine('A', 3);
        Assert.Equal("  A  ", result);
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
}