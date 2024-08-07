namespace GenericInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFirstClass firstClass = new MyFirstClass();
            dynamic r = firstClass.Add(12, 23);
            Console.WriteLine(r);
            MySecondClass secondClass = new MySecondClass();
            r = secondClass.Add(12, 23);
            Console.WriteLine(r);
        }
    }
}
