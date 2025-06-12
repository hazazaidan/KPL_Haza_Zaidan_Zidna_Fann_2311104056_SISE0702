public static class Login
{
    public static void Run()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine().Trim();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        string hashed = UserService.HashPassword(password);
        var users = UserService.LoadUsers();

        if (users.Any(u => u.Username == username && u.PasswordHash == hashed))
        {
            Console.WriteLine("✅ Login berhasil!");
        }
        else
        {
            Console.WriteLine("❌ Username atau password salah.");
        }
    }
}
