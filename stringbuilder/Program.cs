using System.Text;

namespace stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                
                Console.WriteLine("1. Find Exponential");
                Console.WriteLine("2. Replace Word");
                Console.WriteLine("Choose the option:");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    
                    Console.WriteLine("Enter the number:");
                    int number = Convert.ToInt32(Console.ReadLine());

                    
                    StringBuilder exponentialResult = FindExponential(number);
                    Console.WriteLine(exponentialResult);
                }
                else if (option == 2)
                {
                    
                    Console.WriteLine("Enter the sentence:");
                    string sentence = Console.ReadLine();

                    Console.WriteLine("Enter the word to replace:");
                    string word1 = Console.ReadLine();

                    Console.WriteLine("Enter the replacement word:");
                    string word2 = Console.ReadLine();

                    
                    StringBuilder replaceWordResult = ReplaceWord(sentence, word1, word2);
                    Console.WriteLine(replaceWordResult);
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                }
        }

            public static StringBuilder FindExponential(int number)
            {
                
                double exponential = Math.Exp(number); // Math.Exp(number) computes e^number
                StringBuilder sb = new StringBuilder("Exponential is ");
                sb.AppendFormat("{0:E6}", exponential); 
                return sb; 
            }

         
            public static StringBuilder ReplaceWord(string sentence, string word1, string word2)
            {
                StringBuilder sb = new StringBuilder(sentence); // Initialize with the sentence
                sb.Replace(word1, word2); // Replace word1 with word2
                return sb; // Return the modified sentence
            }
        

    }
}

