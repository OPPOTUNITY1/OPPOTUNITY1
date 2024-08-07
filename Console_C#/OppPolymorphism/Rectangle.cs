using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppPolymorphism
{
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
        public override void Display()
        {
            Console.WriteLine("Display Rectangle");
        }
        public new void Print()
        {
            Console.WriteLine("Print Rectangle");
        }
    }
}
