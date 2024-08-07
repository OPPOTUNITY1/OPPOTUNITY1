using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructors
{
    public class Person(string firstName, string lastName)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set;} = lastName;
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
