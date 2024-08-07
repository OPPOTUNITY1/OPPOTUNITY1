using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultInterface
{
    internal class MySample : ISample
    {
        public void Display()
        {
            Console.WriteLine("Hi !");
        }
    }
}
