using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Config
{
    public string Lang { get; set; }
    public Transfer Transfer { get; set; }
    public List<string> Methods { get; set; }
    public Confirmation Confirmation { get; set; }

    private const string FilePath = "bank_transfer_config.json";

    public static Config Load()
    {
        try
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<Config>(json);
            }
            else
            {
                var configBaru = Default();
                configBaru.Save();
                return configBaru;
            }
        }
        catch
        {
            return Default();
        }
    }

    public static Config Default()
    {
        return new Config
        {
            Lang = "en",
            Transfer = new Transfer { Threshold = 25000000, LowFee = 6500, HighFee = 15000 },
            Methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
            Confirmation = new Confirmation { En = "yes", Id = "ya" }
        };
    }

    public void Save()
    {
        string jsonOutput = JsonConvert.SerializeObject(this, Formatting.Indented);
        File.WriteAllText(FilePath, jsonOutput);
    }
}

public class Transfer
{
    public int Threshold { get; set; }
    public int LowFee { get; set; }
    public int HighFee { get; set; }
}

public class Confirmation
{
    public string En { get; set; }
    public string Id { get; set; }
}
