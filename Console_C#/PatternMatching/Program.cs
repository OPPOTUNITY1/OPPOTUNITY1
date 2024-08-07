namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Input data: ");
                int.TryParse(Console.ReadLine(), out int n);
                if(n is int count && count > 0)
                {
                    Console.WriteLine(new String('*', count));
                }
                else
                {
                    Console.WriteLine("Data Invalid");
                }
            }
            Console.WriteLine("---------------------------------------------");
            {
                Console.Write("Input data: ");
                int.TryParse(Console.ReadLine(), out int n);
                switch(n)
                {
                    case int count when count > 0:
                        Console.WriteLine(new string('*', count));
                        break;
                    default:
                        Console.WriteLine("Data Invalid");
                        break;
                }
                
            }
        }
    }
}
