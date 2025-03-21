class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Haza Zaidan Zidna Fann");

        user.AddVideo(new SayaTubeVideo("Titanic"));
        user.AddVideo(new SayaTubeVideo("The Lord of the Rings"));
        user.AddVideo(new SayaTubeVideo("Harry Potter"));
        user.AddVideo(new SayaTubeVideo("Star Wars"));
        user.AddVideo(new SayaTubeVideo("The Avengers"));
        user.AddVideo(new SayaTubeVideo("Joker"));
        user.AddVideo(new SayaTubeVideo("The Lion King"));
        user.AddVideo(new SayaTubeVideo("Frozen"));
        user.AddVideo(new SayaTubeVideo("The Revenant"));
        user.AddVideo(new SayaTubeVideo("The Social Network"));

        user.PrintAllVideoPlaycount();
        Console.ReadKey();
    }
}
