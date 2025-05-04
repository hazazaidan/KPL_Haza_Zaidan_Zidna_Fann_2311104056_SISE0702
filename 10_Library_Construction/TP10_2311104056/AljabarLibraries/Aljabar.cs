using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        // Fungsi untuk mencari akar-akar dari persamaan kuadrat
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];
            double diskriminan = b * b - 4 * a * c;

            if (diskriminan < 0)
                throw new Exception("Akar imajiner, tidak dihitung dalam fungsi ini.");

            double akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);

            // Urutkan dari besar ke kecil
            return (akar1 > akar2) ? new double[] { akar1, akar2 } : new double[] { akar2, akar1 };
        }

        // Fungsi untuk menghitung hasil kuadrat dari persamaan linier (ax + b)^2
        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double x2 = a * a;          // Menghitung a^2
            double x1 = 2 * a * b;      // Menghitung 2ab
            double konstanta = b * b;   // Menghitung b^2

            return new double[] { x2, x1, konstanta };  // Mengembalikan hasil sebagai array {x^2, x, konstanta}
        }
    }
}
