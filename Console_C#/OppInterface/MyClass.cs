using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppInterface
{
    internal class MyClass : IFirst, ISecond
    {
        public void Display()
        {
            Console.WriteLine("Display Method");
        }

        void IFirst.Print()
        {
            Console.WriteLine("IFirst print method");
        }
        void ISecond.Print()
        {
            Console.WriteLine("ISecond print method");
        }
    }
}
