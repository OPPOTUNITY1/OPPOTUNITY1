namespace UsingDeclarations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using var reader = new System.IO.StreamReader(@"C:\in.txt");
                var content = reader.ReadToEnd();
                Console.WriteLine($"File length:{content.Length}");
            }catch (System.IO.FileNotFoundException fe) { 
            
                Console.WriteLine(fe.Message );    
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
        }
    }
}
