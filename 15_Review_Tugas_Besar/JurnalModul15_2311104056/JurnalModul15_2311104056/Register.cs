public static class Register
{
    public static void Run()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine().Trim();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (!UserService.IsValidUsername(username))
        {
            Console.WriteLine("❌ Username tidak valid (ASCII & 4–20 karakter).");
            return;
        }

        if (!UserService.IsValidPassword(password, username))
        {
            Console.WriteLine("❌ Password harus 8–20 karakter, ada angka, simbol, dan tidak mengandung username.");
            return;
        }

        var users = UserService.LoadUsers();
        if (users.Any(u => u.Username == username))
        {
            Console.WriteLine("❌ Username sudah terdaftar.");
            return;
        }

        users.Add(new User
        {
            Username = username,
            PasswordHash = UserService.HashPassword(password)
        });

        UserService.SaveUsers(users);
        Console.WriteLine("✅ Registrasi berhasil.");
    }
}
