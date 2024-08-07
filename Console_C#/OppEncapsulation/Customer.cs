using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppEncapsulation
{
    internal class Customer
    {
        private int id;
        public int CustomerID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string CustomerName { get; set; } = "New customer";
        public void Print()
        {
            Console.WriteLine($"ID: {CustomerID},Name:{CustomerName}");
        }
    }
}
