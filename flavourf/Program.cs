namespace flavourf
{
    public class InvalidFlavourException : Exception
    {
        public InvalidFlavourException(string message) : base(message) { }
    }

    public class Cake
    {
        // Properties
        public string Flavour { get; set; }
        public int QuantityInKg { get; set; }
        public double PricePerKg { get; set; }

        public bool CakeOrder()
        {

            string[] validFlavours = { "Chocolate", "Red Velvet", "Vanilla" };

            if (Array.IndexOf(validFlavours, Flavour) == -1)
            {
                throw new InvalidFlavourException("Flavour not available. Please select the available flavour.");
            }

            if (QuantityInKg <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }

            return true; 
        }

        public double CalculatePrice()
        {
            double discount = Flavour switch
            {
                "Vanilla" => 3,
                "Chocolate" => 5,
                "Red Velvet" => 10,
                _ => 0
            };

            double totalPrice = QuantityInKg * PricePerKg;
            double discountedPrice = totalPrice - (totalPrice * discount / 100);
            return discountedPrice;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Cake cakeOrder = new Cake();

            Console.Write("Enter the flavour: ");
            cakeOrder.Flavour = Console.ReadLine();

            Console.Write("Enter the quantity in kg: ");
            cakeOrder.QuantityInKg = int.Parse(Console.ReadLine());

            Console.Write("Enter the price per kg: ");
            cakeOrder.PricePerKg = double.Parse(Console.ReadLine());

            try
            {
                
                if (cakeOrder.CakeOrder())
                {
                    Console.WriteLine("Cake order was successful");
                
                    double finalPrice = cakeOrder.CalculatePrice();
                    Console.WriteLine($"Price after discount is {finalPrice}");
                }
            }
            catch (InvalidFlavourException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }

}
