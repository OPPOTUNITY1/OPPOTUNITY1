using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordType
{
    public record Customer
    {
        public string Name { get; init; } = "New customer";
        public int Age { get; init; } = 20;
        public void Print()
        {
            Console.WriteLine($"Name:{Name},Age:{Age}");
        }
    }
}
