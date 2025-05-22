class Program
{
    static void Main(string[] args)
    {
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        // Tambahkan data anggota kelompok dan asisten
        data1.AddSebuahData("Jono");
        data1.AddSebuahData("Jafar");
        data1.AddSebuahData("Asisten: Budi");

        Console.WriteLine("Data di data2 (setelah penambahan):");
        data2.PrintSemuaData();

        // Hapus asisten
        data2.HapusSebuahData(2);

        Console.WriteLine("\nData di data1 (setelah penghapusan asisten):");
        data1.PrintSemuaData();

        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}
