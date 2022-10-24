namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {
                int n1 = ReadInt("First number");
                int n2 = ReadInt("Second number");
                int n3 = ReadInt("Third number");

                Console.WriteLine(Operations.Add(n1, n2, n3));
                Console.WriteLine(Operations.Subtract(n1, n2, n3));
                Console.WriteLine(Operations.Multiply(n1, n2, n3));
                Console.WriteLine(Operations.Divide(n1, n2, n3));
            }
        }

        static int ReadInt(string prefix)
        {
            Console.Write($"[PROMPT] :: {prefix} :: ");
            int buffer;
            if(int.TryParse(Console.ReadLine(), out buffer))
            {
                return buffer;
            } else
                Console.WriteLine($"[ERR] :: Must be a number. :: Try again.");

            return ReadInt(prefix);
        }
    }
}