class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("0. Exit");
            Console.Write("Pilih: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Register.Run();
                    break;
                case "2":
                    Login.Run();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}
