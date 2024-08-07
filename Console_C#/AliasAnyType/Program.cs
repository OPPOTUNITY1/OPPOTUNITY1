using Point = (int X, int Y);
using var file = File.OpenRead("data.txt");
using var reader = new StreamReader(file);

namespace AliasAnyType
{
    internal class Program
    {
        static async void Main(string[] args, StreamReader reader)
        {
            Point p = (3, 5);
            Console.WriteLine($"({p.X}, { p.Y})");
            string line = await reader.ReadLineAsync();
        }
    }
}
