namespace StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m1= new MyClass();
            MyClass.x = 4;
            MyClass m2 = new MyClass();
        }
    }
}
