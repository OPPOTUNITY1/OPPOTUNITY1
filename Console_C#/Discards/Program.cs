namespace Discards
{
    internal class Program
    {
        static (string first, string middle, string last) SplitNames(string fullName)
        {
            string[] strArray = fullName.Split(' ');
            return (strArray[0], strArray[1], strArray[2]);
        }
        static void Main(string[] args)
        {
            {
                var (first, _, last) = SplitNames("Philip F Japikse");
                Console.WriteLine($"{first}:{last}");
            }
            Console.WriteLine("-----------------------------------------------------------");
            {
                string[] stringArray = { "12", "Hello", "3.14", "20" };
                for (int i = 0; i < stringArray.Length; i++)
                {
                    if (int.TryParse(stringArray[i],out _))
                    {
                        Console.WriteLine($"{stringArray[i]}: valid");
                    }
                    else
                    {
                        Console.WriteLine($"{stringArray[i]}: Invalid");
                    }
                }
            }
        }
    }
}
