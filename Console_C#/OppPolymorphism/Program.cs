namespace OppPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape p= new Circle();
            p.Display();
            p.Draw();
            p=new Rectangle();
            p.Display();
            p.Draw();
            p.Print();
        }
    }
}
