namespace WorkingWithTheSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using collection initializer to initialize SortedSet
            SortedSet<int> mySet = new SortedSet<int>() { 8, 7, 9, 1, 3 };
            //Add the element in SortedSSet using Add method
            mySet.Add(5);
            mySet.Add(6);
            mySet.Add(4);
            mySet.Add(2);
            Console.WriteLine($"List element: {mySet.Count}");
            Console.WriteLine("Element of mySet:\n");
            //Accessing elements of SortedSet using foreach loop
            foreach(var p in mySet) 
            {
                Console.Write($"{p,3}");
            }
        }
    }
}
