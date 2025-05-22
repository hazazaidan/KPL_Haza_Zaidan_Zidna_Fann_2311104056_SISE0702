using System;

class Program
{
    static void Main()
    {
        InputHuruf();
        CetakBilanganGenap();
    }

    // Method untuk menerima input huruf dan menentukan jenis huruf
    static void InputHuruf()
    {
        Console.Write("Masukkan satu huruf: ");
        char inputChar = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if ("AIUEO".Contains(inputChar))
        {
            Console.WriteLine($"Huruf {inputChar} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {inputChar} merupakan huruf konsonan");
        }
    }

    // Method untuk mencetak array bilangan genap
    static void CetakBilanganGenap()
    {
        int[] evenNumbers = { 2, 4, 6, 8, 10 };

        Console.WriteLine("Daftar angka genap:");
        for (int i = 0; i < evenNumbers.Length; i++)
        {
            Console.WriteLine($"Angka genap ke-{i + 1}: {evenNumbers[i]}");
        }
    }
}
