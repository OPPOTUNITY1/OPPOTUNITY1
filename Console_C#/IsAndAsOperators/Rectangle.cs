using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAndAsOperators
{
    internal class Rectangle : ICalculate
    {
        float length;
        float width;
        public Rectangle(float x, float y)
        {
            length = x;
            width = y;
        }
        public double Area()
        {
            return length * width;
        }
    }
}
