namespace methods
{

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual double CalculateCost(double basePrice, int currentYear)
        {
            return basePrice;
        }
    }

    public class SportsCar : Car
    {
        public override double CalculateCost(double basePrice, int currentYear)
        {
            int age = currentYear - Year;
            double totalTax = basePrice * 0.10 * age; 
            return basePrice + totalTax;
        }
    }

    public class SUV : Car
    {
        public override double CalculateCost(double basePrice, int currentYear)
        {
            int age = currentYear - Year;
            double totalTax = basePrice * 0.05 * age;  
            return basePrice + totalTax;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Sports car");
            Console.WriteLine("2. SUV car");
            Console.WriteLine("3. None of the above");
            Console.Write("Choose the option: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the make: ");
            string make = Console.ReadLine();

            Console.Write("Enter the model: ");
            string model = Console.ReadLine();

            Console.Write("Enter the year the car was made: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter the basic price: ");
            double basePrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the current year: ");
            int currentYear = int.Parse(Console.ReadLine());

            double cost = 0; 

            if (choice == 1)
            {
                SportsCar sportsCar = new SportsCar
                {
                    Make = make,
                    Model = model,
                    Year = year
                };
                cost = sportsCar.CalculateCost(basePrice, currentYear);
                Console.WriteLine($"Sports car cost is {cost}");
            }
            else if (choice == 2)
            {
                SUV suv = new SUV
                {
                    Make = make,
                    Model = model,
                    Year = year
                };
                cost = suv.CalculateCost(basePrice, currentYear);
                Console.WriteLine($"SUV car cost is {cost}");
            }
            else
            {
                Car car = new Car
                {
                    Make = make,
                    Model = model,
                    Year = year
                };
                cost = car.CalculateCost(basePrice, currentYear);
                Console.WriteLine($"The cost is {cost}");
            }
        }
    }

}
