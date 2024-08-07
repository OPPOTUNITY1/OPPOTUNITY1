namespace WorkiingWithTheList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() {FirstName = "David", LastName="SSimpson",Age=50},
                new Person() {FirstName = "Trung", LastName="SSimpson",Age=50},
            };
            Console.WriteLine("Itemss in list: {0}",people.Count);
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
