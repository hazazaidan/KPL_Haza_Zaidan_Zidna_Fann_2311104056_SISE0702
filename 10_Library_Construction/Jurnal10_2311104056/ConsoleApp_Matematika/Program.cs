using System;
using MatematikaLibraries;

class Program
{
    static void Main()
    {
        Console.WriteLine("FPB dari 60 dan 45: " + MathHelper.FPB(60, 45));         // Output: 15
        Console.WriteLine("KPK dari 12 dan 8: " + MathHelper.KPK(12, 8));           // Output: 24

        int[] persamaan1 = { 1, 4, -12, 9 };
        Console.WriteLine("Turunan dari x^3 + 4x^2 - 12x + 9: " + MathHelper.Turunan(persamaan1));
        // Output: 3x2 +8x -12

        int[] persamaan2 = { 4, 6, -12, 9 };
        Console.WriteLine("Integral dari 4x^3 + 6x^2 - 12x + 9: " + MathHelper.Integral(persamaan2));
        // Output: x4 +2x3 -6x2 +9x + C
    }
}
