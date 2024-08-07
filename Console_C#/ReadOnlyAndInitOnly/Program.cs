namespace ReadOnlyAndInitOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass { x=1};
            Console.WriteLine($"x:{obj1.x}, y:{obj1.y}");
            //obj.x=10;//error
            //obj.y=20; //error
            MyClass obj2 = new MyClass();
            Console.WriteLine($"x:{obj2.x},y={obj2.y}");
            MyClass obj3= new MyClass(30,50);
            Console.WriteLine($"x:{obj3.x},y:{obj3.y}");
        }
    }
}
