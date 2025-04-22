using System;
using System.IO;
using System.Text.Json;

namespace TPModul7
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class DataMahasiswa2311104056
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }

        public static void ReadJSON()
        {
            string filePath = "tp7_1_2311104056.json"; // Ganti sesuai nama file JSON kamu
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File JSON tidak ditemukan.");
                return;
            }

            string jsonString = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<DataMahasiswa2311104056>(jsonString);

            if (data != null)
            {
                Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
            }
            else
            {
                Console.WriteLine("Gagal melakukan deserialisasi JSON.");
            }
        }
    }
}
