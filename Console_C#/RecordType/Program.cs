using System.Runtime.InteropServices;

namespace RecordType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer01 = new Customer { Name = "Jack", Age = 25 };
            customer01.Print();
            Customer customer02 = customer01 with { Name = "John" };
            customer02.Print();
            Customer customer03 = new();
            customer03.Print();
        }
    }
}
