using System;
using AljabarLibraries;

namespace AljabarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Test Akar Persamaan Kuadrat ==");
            double[] persamaanKuadrat = { 1, -3, -10 }; // x^2 - 3x - 10 = 0
            double[] akar = Aljabar.AkarPersamaanKuadrat(persamaanKuadrat);
            Console.WriteLine($"Akar-akar: {akar[0]}, {akar[1]}");

            Console.WriteLine("\n== Test Hasil Kuadrat (ax + b)^2 ==");
            double[] linier = { 2, -3 }; // (2x - 3)^2
            double[] hasilKuadrat = Aljabar.HasilKuadrat(linier);
            // Menggunakan string.Join untuk format output seperti yang diinginkan
            Console.WriteLine($"Hasil kuadrat: {string.Join(", ", hasilKuadrat)}");
        }
    }
}
