
namespace ggtkgv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 13, 22, 3, 41, 20, 43, 9 };
            Console.WriteLine("Array: [{0}]", string.Join(", ", arr));

            Console.WriteLine("Mittelwert: " + MyMath.MwArr(arr));
            Console.WriteLine("Kl. Wert: " + MyMath.KwArr(arr));
            Console.WriteLine("Gr. Wert: " + MyMath.GwArr(arr));

            MyMath.ReverseArray(ref arr);
            Console.WriteLine("Umgekehrt: [{0}]", string.Join(", ", arr));

            Console.WriteLine("kgV & ggT Rechner: 0 zum Abbruch.");

            for (;;) {
                int n1 = ReadInt("Zahl 1");
                if (n1 == -1) { continue; }
                if (n1 == 0) { break; }
                int n2 = ReadInt("Zahl 2");

                Console.WriteLine($"{n1} : {n2}\n..swap..");
                MyMath.SwapVars(ref n1, ref n2);
                Console.WriteLine($"{n1} : {n2}");

                int ggt = MyMath.Calc_ggT_r(n1, n2);
                int kgv = MyMath.Calc_kgV(n1, n2);

                Console.WriteLine($"ggT von {n1} und {n2} ist [{ggt}] resp. kgV von {n1} und {n2} ist [{kgv}]\n");
            }

            Console.WriteLine("Ende");
        }

        static int ReadInt(string prefix)
        {
            Console.Write($"{prefix}: ");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                return num;
            } else
            {
                return -1;
            }
            //try
            //{
            //     num = Convert.ToInt32(Console.ReadLine());
            //} catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}