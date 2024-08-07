using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    interface IBasic<T> where T:struct
    {
        T Add(T a, T b);
    }
}
