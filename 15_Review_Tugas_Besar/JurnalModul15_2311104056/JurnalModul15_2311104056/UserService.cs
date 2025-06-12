using System.Security.Cryptography;
using System.Text;
using System.Xml;
using Newtonsoft.Json;

public static class UserService
{
    private static string filePath = @"D:\KPL2\KPL_Haza_Zaidan_Zidna_Fann_2311104056_SISE0702\15_Review_Tugas_Besar\JurnalModul15_2311104056\JurnalModul15_2311104056\users.json";

    public static List<User> LoadUsers()
    {
        if (!File.Exists(filePath)) return new List<User>();
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<User>>(json);
    }

    public static void SaveUsers(List<User> users)
    {
        string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);

        File.WriteAllText(filePath, json);
    }

    public static string HashPassword(string password)
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }

    public static bool IsValidUsername(string username)
    {
        return username.All(c => c >= 32 && c <= 126) && username.Length >= 4 && username.Length <= 20;
    }

    public static bool IsValidPassword(string password, string username)
    {
        return password.Length >= 8 && password.Length <= 20 &&
               password.Any(char.IsDigit) &&
               "!@#$%^&*".Any(password.Contains) &&
               !password.ToLower().Contains(username.ToLower());
    }
}
