namespace boxing
{
    public class Program
    {
        public static object CalculateDiscountedPrice(object totalCost)
        {
           
            double cost = (double)totalCost;

            double discount = 0;

            if (cost >= 100 && cost <= 500)
            {
                discount = 0.05 * cost; 
            }
            else if (cost > 500 && cost <= 1000)
            {
                discount = 0.15 * cost; 
            }
            else if (cost > 1000)
            {
                discount = 0.30 * cost; 
            }

            double discountedPrice = cost - discount;

            return (object)discountedPrice;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total cost:");
            double totalCost = double.Parse(Console.ReadLine());

            object result = CalculateDiscountedPrice((object)totalCost); // Boxing

            Console.WriteLine("Price after discount is: " + (double)result);
        }
    }
}
