namespace constructor
{
    public class Book
    {
        // Private fields for book details
        private string title;
        private string author;
        private int numPages;
        private DateTime dueDate;
        private DateTime returnedDate;

        // Default constructor
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            numPages = 0;
            dueDate = DateTime.Now;
            returnedDate = DateTime.Now;
        }
        public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }

        public double AveragePagesReadPerDay(int daysToRead)
        {
            return (double)numPages / daysToRead;
        }

        public double CalculateLateFee(double dailyLateFeeRate)
        {

            int daysLate = (returnedDate - dueDate).Days;

            if (daysLate > 0)
            {
                return daysLate * dailyLateFeeRate;
            }
            else
            {
                return 0;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Enter the title:");
                string title = Console.ReadLine();

                Console.WriteLine("Enter the author:");
                string author = Console.ReadLine();

                Console.WriteLine("Enter the number of pages:");
                int numPages = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the due date (MM/DD/YYYY):");
                DateTime dueDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter the return date (MM/DD/YYYY):");
                DateTime returnedDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter the days to read:");
                int daysToRead = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the daily late fee rate:");
                double dailyLateFeeRate = double.Parse(Console.ReadLine());

                Book book = new Book(title, author, numPages, dueDate, returnedDate);

                double averagePagesRead = book.AveragePagesReadPerDay(daysToRead);
                double lateFee = book.CalculateLateFee(dailyLateFeeRate);

                Console.WriteLine($"Average Pages Read Per Day : {Math.Round(averagePagesRead, 2)}");
                Console.WriteLine($"Late Fee : {Math.Round(lateFee, 2)}");
        }
    }

}


