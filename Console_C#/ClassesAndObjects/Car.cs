using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {
        public string Make;
        public string Model;
        public void Starting()
        {
            Console.WriteLine($"{Model} is starting");
        }
        public void Accelerating()
        {
            Console.WriteLine($"{Model} is accelerating");
        }
        public void Braking()
        {
            Console.WriteLine($"{Model} is braking");
        }
        public override string ToString()
        {
            return $"Make={Make}, Model={Model}";
        }
    }
}
