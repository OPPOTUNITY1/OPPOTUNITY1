namespace GenericMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating object of MyClass
            MyClass obj = new MyClass();
            //Calling Generic method
            obj.Display<string, int>("Integer", 2050);
            obj.Display<double, char>(155.9, 'A');
            obj.Display<float, double>(358.9F, 255.67);
        }
    }
}
