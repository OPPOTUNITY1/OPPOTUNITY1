namespace ImplementPrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");
            Car musang = new Mustang("Mustang EcoBoost");
            Car bentley = new Mustang("Continental GT Mulliner");
            Console.WriteLine($"Car is: {musang.ModelName}, and it's base price is Rs.{musang.BasePrice}");
            Console.WriteLine($"Car is: {musang.ModelName}, and it's base price is Rs.{bentley.BasePrice}");

            Car Car;
            Car = musang.Clone();
            Car.OnRoadPrice = Car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {Car.ModelName}, and it's price is Rs.{Car.OnRoadPrice}");
            Car = bentley.Clone();
            Car.OnRoadPrice = Car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {Car.ModelName}, and it's price is Rs.{Car.OnRoadPrice}");
            Console.ReadLine();
        }
    }
}
