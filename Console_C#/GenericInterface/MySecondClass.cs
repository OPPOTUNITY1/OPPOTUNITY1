using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    internal class MySecondClass : IBasic<double>
    {
        public double Add(double a, double b) => a + b;
    }
}
