using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPrototypePattern
{
    public class Mustang : Car
    {
        public Mustang(string mode) => (ModelName, BasePrice) = (ModelName, 200_000);
        public override Car Clone()=> this.MemberwiseClone() as Mustang;
    }
}
