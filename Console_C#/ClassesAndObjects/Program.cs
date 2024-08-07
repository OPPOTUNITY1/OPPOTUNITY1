namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car wwPolo = new Car();
            wwPolo.Make = "2050";
            wwPolo.Model = "Volkswagen Polo";
            wwPolo.Accelerating();
            wwPolo.Braking();
            wwPolo.Starting();
            Console.WriteLine($"Car: {wwPolo}");
        }
    }
}
