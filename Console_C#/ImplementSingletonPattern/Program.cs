namespace ImplementSingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1.Trying to get a Singleton instance, called firstInstance.");
            Singleton firstInstance = Singleton.GetInstance;
            Console.Write("--Invoke Print() method: ");
            firstInstance.Print();
            Console.WriteLine("#2.Trying to get another Singleton instance, called secondInstance");
            Singleton secondeInstance = Singleton.GetInstance;
            Console.WriteLine($"--Number of instance:{secondeInstance.GetTotalInstances}");
            Console.Write("--Invoke Print() method: ");
            secondeInstance.Print();
            if(firstInstance.Equals(secondeInstance))
            {
                Console.WriteLine("=> THe firstInstance and secondInstance are the same");

            }
            else
            {
                Console.WriteLine("=> Difference instance exist.");
            }
            Console.Read();
        }
    }
}
