namespace OppEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.CustomerID = 10000;
            Console.WriteLine($"ID:{obj.CustomerID},Name:{obj.CustomerName}");
            obj.CustomerID = 20000;
            obj.CustomerName = "Jack";
            obj.Print();
        }
    }
}
