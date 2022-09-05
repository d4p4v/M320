namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();

            r1.Enabled = true;
            r1.Name = "My Rectangle";
            
            Console.WriteLine(
                $"Rectangle: {r1.Name}\n" +
                $"{r1.SizeAsString}"
            );
        }
    }
}