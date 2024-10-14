namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the movie name ");
           string moviename = Console.ReadLine();

            Console.WriteLine("Enter the ticket id ");
            int ticketId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seat number");
            string seatnumber = Console.ReadLine();

            Console.WriteLine($"Movie name : {moviename}");
            Console.WriteLine($"Ticket id : {ticketId}");
            Console.WriteLine($"Seat number : {seatnumber}");
        }
    }
}
