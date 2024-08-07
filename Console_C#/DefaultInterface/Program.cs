namespace DefaultInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            MySample obj = new MySample();
            obj.Display();
            ISample.Print();
            ISample sample = obj;
            str = sample.GetString("Jack");
            Console.WriteLine(str);
        }
    }
}
