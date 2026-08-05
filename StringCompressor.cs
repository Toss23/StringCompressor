using System.Text;

public static class StringCompressor
{
    public static string Compress(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        StringBuilder result = new StringBuilder();
        int i = 0;
        while (i < input.Length)
        {
            char current = input[i];
            int count = 1;
            while (i + count < input.Length && input[i + count] == current)
                count++;

            result.Append(current);
            if (count > 1)
                result.Append(count);

            i += count;
        }
        return result.ToString();
    }
    
    public static string Decompress(string compressed)
    {
        if (string.IsNullOrEmpty(compressed)) return compressed;

        StringBuilder result = new StringBuilder();
        int i = 0;
        while (i < compressed.Length)
        {
            char c = compressed[i];
            i++;
            if (i < compressed.Length && char.IsDigit(compressed[i]))
            {
                int count = 0;
                while (i < compressed.Length && char.IsDigit(compressed[i]))
                {
                    count = count * 10 + (compressed[i] - '0');
                    i++;
                }
                result.Append(c, count);
            }
            else
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
}