namespace AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new { id = 1000, name = "Jack" };
            Console.WriteLine($"id:{obj1.id},name:{obj1.name}");
            dynamic obj2 = new { id = 2000, name = "Scott", Email = "Scot@gmail.com" };
            Console.WriteLine($"id:{obj2.id},name:{obj2.name},Email:{obj2.Email}");
        }
        
    }
}
