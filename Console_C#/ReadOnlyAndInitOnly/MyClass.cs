using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyAndInitOnly
{
    internal class MyClass
    {
        //Init only properties
        public int x {  get; init; }
        //Read only properties
        public int y { get; }
        public MyClass()
        {
            x = 10;
            y = 20;
        }
        public MyClass(int a, int b)
        {
            x = a;
            y= b;
        }
    }
}
