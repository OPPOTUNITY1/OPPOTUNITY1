using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPWithC_
{
    public class Employee(string firstName, string lastName, DateOnly hireDate, decimal salary)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;

        public DateOnly HireDate { get; set; } = hireDate;
        public decimal Salary { get; set; } = salary;
        public override string ToString()
        {
            return $"Name:{FirstName} {LastName} Date: {HireDate} Salary: {Salary}";
        }
    }
}
