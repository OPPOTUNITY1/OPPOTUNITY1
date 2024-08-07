using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementSingletonPattern
{
    internal class Singleton
    {
        private static readonly Singleton Instance;
        private static int TotalInstances = 0;
        private Singleton() => Console.WriteLine("--Private constructor is called");
        static Singleton()
        {
            Console.WriteLine("--Static constructor is called.");
            Instance = new Singleton();
            TotalInstances++;
            Console.WriteLine($"Singleton instance is created. Number of instances:{TotalInstances}");
            Console.WriteLine("Exit from static constructor");
        }
        public static Singleton GetInstance => Instance;
        public int GetTotalInstances => TotalInstances;
        public void Print() => Console.WriteLine("Hello World");
    }
}
