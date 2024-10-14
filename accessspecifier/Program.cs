namespace accessspecifier
{
    public class Owner
    {
        protected string ownerName;
    }
    public class Car : Owner
    {
        internal double price;
        private string bodyStyle;

        public string BodyStyle
        {
            get { return bodyStyle; }
            set { bodyStyle = value; }
        }

        public bool ValidateBodyStyle(string bodyStyle)
        {
            if (bodyStyle == "SUV" || bodyStyle == "Sedan")
            {
                return true;
            }
            return false;
        }

        public double CalculatePrice()
        {
            if (bodyStyle == "SUV")
            {
                return price - (price * 10 / 100);
            }
            else if (bodyStyle == "Sedan")
            {
                return price - (price * 25 / 100);
            }
            return 0;
        }

        public void SetOwnerName(string name)
        {
            ownerName = name;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("Enter the owner name:");
            string ownerName = Console.ReadLine();

            Console.WriteLine("Enter the car body style:");
            string bodyStyle = Console.ReadLine();

            Console.WriteLine("Enter the price:");
            car.price = double.Parse(Console.ReadLine());

            if (!car.ValidateBodyStyle(bodyStyle))
            {
                Console.WriteLine("Invalid Car Type");
            }
            else
            {

                car.BodyStyle = bodyStyle;
                double finalPrice = car.CalculatePrice();

                car.SetOwnerName(ownerName);

                Console.WriteLine($"The owner sells the {bodyStyle} type car for ${finalPrice}");
            }
        }
    }
}






        
        
    
