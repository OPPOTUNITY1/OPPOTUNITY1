namespace ReadonlyMemberAndConstKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamplePoint p1 = new SamplePoint(11,21,32);
            Console.WriteLine($"t={SamplePoint.t}");
            Console.WriteLine($"p1: x={p1.x},y={p1.y},z={p1.z}");
            SamplePoint p2 = new SamplePoint();
            Console.WriteLine($"p2: x={p2.x},y={p2.y},z={p2.z}");
        }
    }
}
