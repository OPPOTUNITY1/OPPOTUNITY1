
namespace LocalFunctionAndStaticLocalFunction
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            {
            int x = 1;
            int y = 2;
            void AddValue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is: " + b);
                Console.WriteLine("Value of x is: " + x);
                Console.WriteLine("Value of y is: " + y);
                Console.WriteLine("Sum: {0}",a+b+x+y);
            }
            AddValue(3, 4);
            AddValue(5, 6);
            }
            Console.WriteLine("---------------------------------------------------");
            { 
                void AreaOfCircle(double a)
                {
                    double ar;
                    Console.WriteLine("Radius of the circle: " +a);
                    ar = 3.14 * a * a;
                    Console.WriteLine("Area of circle: " + ar);
                    Circumference(a);
                    static void Circumference(double radii)
                    {
                        double cr;
                        cr = 2*3.14*radii;
                        Console.WriteLine($"Circumference of the circle is:{cr:N2}");
                    }
                }
                AreaOfCircle(10);
            }
        }

        
    }
}
