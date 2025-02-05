﻿namespace GenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance of string type
            MyClass<string> name = new MyClass<string>() { Value="Jack"};
            Console.WriteLine(name);
            //Instance of float type
            MyClass<float> version = new MyClass<float>() { Value = 5.5f };
            Console.WriteLine(version);
            //Instance of dynamic type
            dynamic obj = new { Id = 1, Name = "David" };
            MyClass<dynamic> myClass = new MyClass<dynamic>() {  Value = obj };
            Console.WriteLine(myClass);
        }
    }
}
