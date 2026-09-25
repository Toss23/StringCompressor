public class UnitTests
{
    [Fact]
    public void Compress_SimpleString_ReturnsCorrect()
    {
        string original = "aaabbcccdde";
        string compressed = "a3b2c3d2e";
        Assert.Equal(StringCompressor.Compress(original), compressed);
    }

    [Fact]
    public void Decompress_CompressedString_ReturnsOriginal()
    {
        string original = "aaabbcccdde";
        string compressed = StringCompressor.Compress(original);
        Assert.Equal(original, StringCompressor.Decompress(compressed));
    }

    [Fact]
    public void Compress_NoRepeats_ReturnsSame()
    {
        Assert.Equal("abc", StringCompressor.Compress("abc"));
    }

    [Fact]
    public void Decompress_NoNumbers_ReturnsSame()
    {
        Assert.Equal("abc", StringCompressor.Decompress("abc"));
    }
}