using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class Utils
    {
        public static int Add(int a, int b) {  return a + b; }
        public static int Sub(this int a, int b) { return a-b; }
    }
}
