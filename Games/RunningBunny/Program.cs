namespace RunningBunny;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();

        using (new RunningBunnyGame().Run()) { }
    }
}