namespace ImplementFactoriesMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory Method Pattern Demo.***\n");
            List<AnimalFactory> animalFactoryList = new List<AnimalFactory>
            {
                new TigerFactory(),
                new LionFactory()
        };
            foreach(var animal in animalFactoryList)
            {
                animal.CreateAnimal().AboutMe();
            }
        }
    }
}
