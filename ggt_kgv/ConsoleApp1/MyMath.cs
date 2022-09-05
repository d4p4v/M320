using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ggtkgv
{
    public class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            while(b != 0)
            {
                int z = a % b;
                a = b;
                b = z;
            }

            return a;
        }

        public static int Calc_ggT(int a)
        {

            return a * 2;
        }

        public static int Calc_kgV(int a, int b)
        {
            return (a / Calc_ggT(a, b)) * b;
        }

        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            } else
            {
                return Calc_ggT_r(b, a % b);
            }
        }

        public static int MwArr(int[] arr)
        {
            return Convert.ToInt32(arr.Average());
        }

        public static int GwArr(int[] arr)
        {
            return arr.Max();
        }

        public static int KwArr(int[] arr)
        {
            return arr.Min();
        }

        public static void SwapVars(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;

        }

        public static void ReverseArray(ref int[] arr)
        {
            arr = arr.Reverse().ToArray();
        }

        public static void SortArray(ref int[] arr)
        {
            Array.Sort(arr);
        }
    }
}
