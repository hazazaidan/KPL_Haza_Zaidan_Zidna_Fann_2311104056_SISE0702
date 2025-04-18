using System;
using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    public CovidConfig()
    {
        string path = "covid_config.json";

        string defaultSatuanSuhu = "celcius";
        int defaultBatasHariDemam = 14;
        string defaultPesanDitolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        string defaultPesanDiterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

        if (File.Exists(path))
        {
            string jsonContent = File.ReadAllText(path);
            try
            {
                var configData = JsonSerializer.Deserialize<ConfigData>(jsonContent);
                if (configData != null)
                {
                    this.satuan_suhu = configData.satuan_suhu ?? defaultSatuanSuhu;
                    this.batas_hari_deman = configData.batas_hari_deman;
                    this.pesan_ditolak = configData.pesan_ditolak ?? defaultPesanDitolak;
                    this.pesan_diterima = configData.pesan_diterima ?? defaultPesanDiterima;
                }
                else
                {
                    this.satuan_suhu = defaultSatuanSuhu;
                    this.batas_hari_deman = defaultBatasHariDemam;
                    this.pesan_ditolak = defaultPesanDitolak;
                    this.pesan_diterima = defaultPesanDiterima;
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing JSON: {ex.Message}");
                // Use default values if deserialization fails
                this.satuan_suhu = defaultSatuanSuhu;
                this.batas_hari_deman = defaultBatasHariDemam;
                this.pesan_ditolak = defaultPesanDitolak;
                this.pesan_diterima = defaultPesanDiterima;
            }
        }
        else
        {
            this.satuan_suhu = defaultSatuanSuhu;
            this.batas_hari_deman = defaultBatasHariDemam;
            this.pesan_ditolak = defaultPesanDitolak;
            this.pesan_diterima = defaultPesanDiterima;
        }
    }

    public void UbahSatuan()
    {
        if (satuan_suhu.ToLower() == "celcius")
            satuan_suhu = "fahrenheit";
        else
            satuan_suhu = "celcius";
    }
}

// Create a simple class to hold the JSON data during deserialization
public class ConfigData
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }
}