﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    internal class MyFirstClass : IBasic<int>
    {
        public int Add(int a, int b) => a + b;
    }
}
