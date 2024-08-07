namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int i = 123;
                //Boxing copies the value of i into object o.
                object o = i;
                //change value of i
                i = 456;
                //The change in i doesn't affect the value stored in o.
                Console.WriteLine("The value-type value ={0}", i);
                Console.WriteLine("The objcet-type value ={0}", o);
            }            
            Console.WriteLine("--------------------------------------------");
            {
                int i = 123;
                object o = i;
                int j = (int)o;
                Console.WriteLine("i={0}, o={1}, j={2}", i, j, o);
            }
            
        }
    }
}
