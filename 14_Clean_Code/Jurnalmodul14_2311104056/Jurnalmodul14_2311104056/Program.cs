using System;

class Program
{
    static void Main()
    {
        // A. Menerima input nama pengguna
        Console.Write("Masukkan nama Anda: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {userName}!");

        // B. Inisialisasi array dengan 50 elemen
        int[] numbers = new int[50];
        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = index;

            if (index % 2 == 0 && index % 3 == 0)
                Console.WriteLine($"{index} #$#$");
            else if (index % 2 == 0)
                Console.WriteLine($"{index} ##");
            else if (index % 3 == 0)
                Console.WriteLine($"{index} $$");
            else
                Console.WriteLine($"{index}");
        }

        // C. Cek apakah bilangan prima
        Console.Write("Masukkan angka (1-10000): ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(inputNumber))
            Console.WriteLine($"Angka {inputNumber} merupakan bilangan prima");
        else
            Console.WriteLine($"Angka {inputNumber} bukan merupakan bilangan prima");
    }

    /// <summary>
    /// Mengecek apakah sebuah angka merupakan bilangan prima.
    /// </summary>
    /// <param name="number">Angka yang akan dicek</param>
    /// <returns>True jika prima, false jika bukan</returns>
    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int divisor = 2; divisor * divisor <= number; divisor++)
        {
            if (number % divisor == 0)
                return false;
        }

        return true;
    }
}
