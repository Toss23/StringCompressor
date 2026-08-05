public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        while (input != "")
        {
            string compressed = StringCompressor.Compress(input);
            string decompressed = StringCompressor.Decompress(compressed);
            Console.WriteLine($"{input} -> {compressed} -> {decompressed}");
            
            Console.Write("Введите строку: ");
            input = Console.ReadLine();
        }
    }
}