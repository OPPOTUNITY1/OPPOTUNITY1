﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppInheritance
{
    internal class Employee
    {
        private int id;
        private string name;
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
