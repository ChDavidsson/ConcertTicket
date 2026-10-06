namespace ConcertTicket;

class Program
{
    static void Main(string[] args)
    {
        Ticket ticket1 = new Ticket();
        ticket1.ReadInfo();
        ticket1.PrintTicket();

    }
}
