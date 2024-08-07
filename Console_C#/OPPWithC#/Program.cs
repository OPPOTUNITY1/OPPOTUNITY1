using System.Drawing;
using Point = (int X, int Y);

namespace OPPWithC_
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var employee = new Employee("John", "DOE", new DateOnly(2020, 1, 1), 50000);
            Console.WriteLine(employee);
            Console.WriteLine("-------------------------------------------------------");
            Point p = (3, 5);
            Console.WriteLine($"{p.X}, {p.Y}");
        }
    }
}
