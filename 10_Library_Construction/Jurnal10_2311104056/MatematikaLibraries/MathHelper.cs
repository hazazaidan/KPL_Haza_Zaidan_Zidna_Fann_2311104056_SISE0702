using System;
using System.Collections.Generic;

namespace MatematikaLibraries
{
    public class MathHelper
    {
        public static int FPB(int input1, int input2)
        {
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }

        public static int KPK(int input1, int input2)
        {
            return (input1 * input2) / FPB(input1, input2);
        }

        public static string Turunan(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            int pangkat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i] * (pangkat - i);
                int derajat = pangkat - i - 1;

                if (koef == 0) continue;

                string term = "";

                if (koef > 0 && hasil.Count > 0)
                    term += "+";

                if (derajat == 0)
                    term += $"{koef}";
                else if (derajat == 1)
                    term += $"{koef}x";
                else
                    term += $"{koef}x{derajat}";

                hasil.Add(term);
            }

            return string.Join(" ", hasil);
        }

        public static string Integral(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            int pangkat = persamaan.Length;

            for (int i = 0; i < persamaan.Length; i++)
            {
                double koef = (double)persamaan[i] / (pangkat - i);
                int derajat = pangkat - i;

                string strKoef = koef == 1 ? "" :
                                 koef == -1 ? "-" :
                                 koef.ToString("G");

                string term = "";

                if (koef > 0 && hasil.Count > 0)
                    term += "+";

                if (derajat == 1)
                    term += $"{strKoef}x";
                else
                    term += $"{strKoef}x{derajat}";

                hasil.Add(term);
            }

            hasil.Add("+ C");
            return string.Join(" ", hasil);
        }
    }
}
