using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkiingWithTheList
{
    internal class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; } 
        public string LastName {  get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}
