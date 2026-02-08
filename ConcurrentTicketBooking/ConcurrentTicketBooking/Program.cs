
using ConcurrentTicketBooking;

class Program
{
    public static void Main(string[] args)
    {
        SeatUtility sobj = new SeatUtility();
        Console.WriteLine("Enter the seat no you want to Book (101-130)");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter User Name");
        string username = Console.ReadLine();
        sobj.BookSeat(n,username);
        sobj.ShowEmptySeats();
    }
}
