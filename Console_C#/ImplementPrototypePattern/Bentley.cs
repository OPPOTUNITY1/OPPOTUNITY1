using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPrototypePattern
{
    public class Bentley : Car
    {
        public Bentley(string model) => (ModelName, BasePrice) = (model, 300_000);
        public override Car Clone()=>this.MemberwiseClone() as Bentley;
    }
}
