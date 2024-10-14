namespace calculate
{
    public class Candy
    {
        public string Flavour { get; set; }
        public int Quantity { get; set; }
        public int PricePerPiece { get; set; }
        public double TotalPrice { get; set; }
        public double Discount { get; set; }

        public bool ValidateCandyFlavour()
        {
            if (Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint")
            {
                return true;
            }
            return false;
        }
    }
    public class Program
    {
        public Candy CalculateDiscountedPrice(Candy candy)
        {
            candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

            if (candy.Flavour == "Strawberry")
            {
                candy.Discount = candy.TotalPrice - (candy.TotalPrice * 15 / 100);
            }
            else if (candy.Flavour == "Lemon")
            {
                candy.Discount = candy.TotalPrice - (candy.TotalPrice * 10 / 100);
            }
            else if (candy.Flavour == "Mint")
            {
                candy.Discount = candy.TotalPrice - (candy.TotalPrice * 5 / 100);
            }

            return candy;
        }


        static void Main(string[] args)
        {
            Candy candy = new Candy();

            Console.WriteLine("Enter the flavour:");
            candy.Flavour = Console.ReadLine();

            Console.WriteLine("Enter the quantity:");
            candy.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per piece:");
            candy.PricePerPiece = int.Parse(Console.ReadLine());

            
            if (candy.ValidateCandyFlavour())
            {
                Program program = new Program();
                candy = program.CalculateDiscountedPrice(candy);

                Console.WriteLine("Flavour : " + candy.Flavour);
                Console.WriteLine("Quantity : " + candy.Quantity);
                Console.WriteLine("Price Per Piece : " + candy.PricePerPiece);
                Console.WriteLine("Total Price : " + candy.TotalPrice);
                Console.WriteLine("Discount Price : " + candy.Discount);
            }
            else
            {
                Console.WriteLine("Invalid flavour");
            }
        }
    }
}
