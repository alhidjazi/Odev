// See https://aka.ms/new-console-template for more information
using Odev;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GamerManager gamerManager = new GamerManager(new UserValidationManager());
        gamerManager.Add(new Gamer { 
            Id=1,FirstName="osman",
            LastName="musa",
            Birth=1994,
            TcNo=1234566}
        );
    }
}