using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class MyClass<T>
    {
        private T data;
        public T Value { get => data; set=> data = value; }
        public override string ToString() => $"Value:{data}";
    }
}
