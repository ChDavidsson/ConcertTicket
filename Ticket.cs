namespace ConcertTicket;

public class Ticket
{
    // Klass Ticket med EventName, Place, SeatNumber.
    public string EventName;
    public string Place;
    public string SeatNumber;
    // ReadInfo() frågar användaren efter värden.
    public void ReadInfo()
    {
        Console.WriteLine("Ange evenemangsnamn:");
        EventName = Console.ReadLine()!;
        Console.WriteLine("Ange plats:");
        Place = Console.ReadLine()!;
        Console.WriteLine("Ange sittplatsnummer:");
        SeatNumber = Console.ReadLine()!;
    }
    // PrintTicket() skriver ut en liten biljett i konsolen:
    public void PrintTicket()
    {
        Console.WriteLine("*************************");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Evenemang: {EventName}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Plats: {Place}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Sittplatsnummer: {SeatNumber}");
        Console.WriteLine("*************************");
    }
}