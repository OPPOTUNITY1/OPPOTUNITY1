using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ImplementFactoriesMethod
{
    public interface IAnimal
    {
        void AboutMe();
    }
    public class Lion:IAnimal
    {
        public void AboutMe() => WriteLine("This is Lion.");
    }
    public class Tiger:IAnimal
    {
        public void AboutMe() => WriteLine("The is Tiger");
    }

}
