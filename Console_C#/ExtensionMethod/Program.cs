namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 2;
            int r = Utils.Add(x, y);
            Console.WriteLine("{0} + {1} = {2}",x,y,r);
            r= Utils.Sub(x, y);
            Console.WriteLine($"{x} - {y} = {r}");
        }
    }
}
