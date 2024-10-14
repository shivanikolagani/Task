namespace array
{
    public class Program
    {
        public static string UpdatePrice(string[] details, int id, double amount)
        {
            
            for (int i = 0; i < details.Length; i++)
            {
                
                string[] productInfo = details[i].Split(':');
                int productId = int.Parse(productInfo[0]);
                string productName = productInfo[1];
                double productPrice = double.Parse(productInfo[2]);

               
                if (productId == id)
                {
                    return productName + " " + amount;
                }
            }

            return "";
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of products:");
            int numProducts = int.Parse(Console.ReadLine());

            string[] productDetails = new string[numProducts];
            Console.WriteLine("Enter the product details:");
            for (int i = 0; i < numProducts; i++)
            {
                productDetails[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the product id:");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to update:");
            double newAmount = double.Parse(Console.ReadLine());

            string result = UpdatePrice(productDetails, productId, newAmount);

            if (result == "")
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}

