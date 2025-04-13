using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Choose language (en/id): ");
        string language = Console.ReadLine()?.Trim().ToLower();
        bool english = language == "en";

        Config cfg = Config.Load();
        cfg.Lang = english ? "en" : "id";

        Console.WriteLine(english
            ? "Input the amount of money you want to transfer:"
            : "Masukkan jumlah uang yang ingin ditransfer:");
        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= cfg.Transfer.Threshold ? cfg.Transfer.LowFee : cfg.Transfer.HighFee;
        int total = amount + fee;

        Console.WriteLine(english ? $"Transfer fee: {fee}" : $"Biaya transfer: {fee}");
        Console.WriteLine(english ? $"Total amount: {total}" : $"Jumlah total: {total}");

        Console.WriteLine(english ? "Available methods:" : "Metode yang tersedia:");
        for (int i = 0; i < cfg.Methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {cfg.Methods[i]}");
        }

        Console.Write(english ? "Select method: " : "Pilih metode: ");
        string method = Console.ReadLine();

        Console.WriteLine(english
            ? $"Confirm transfer? ({cfg.Confirmation.En}/no)"
            : $"Konfirmasi transfer? ({cfg.Confirmation.Id}/tidak)");
        string confirmInput = Console.ReadLine()?.Trim().ToLower();

        bool confirmed = english
            ? confirmInput == cfg.Confirmation.En
            : confirmInput == cfg.Confirmation.Id;

        if (confirmed)
        {
            Console.WriteLine(english ? "Transfer successful." : "Transfer berhasil.");
        }
        else
        {
            Console.WriteLine(english ? "Transfer canceled." : "Transfer dibatalkan.");
        }
    }
}
