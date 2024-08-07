using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    public class MyClass
    {
        //Genderic method with two types T and U
        public void Display<T,U>(T msg, U value)
        {
            Console.WriteLine($"{msg} : {value}");
        }
    }
}
