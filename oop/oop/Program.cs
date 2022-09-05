namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanziieren einer Klasse (Aus einer Klasse wird ein Objekt)
            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle();

            // Setter
            rectangle1.Name = "Ben";

            // Getter
            Console.WriteLine($"{rectangle1.Name}: {rectangle1.Area}");
            Console.WriteLine($"{rectangle2.Name}: {rectangle2.Area}");
        }
    }
}