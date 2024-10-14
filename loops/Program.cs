using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace string1
{
    public class Program
    {
        static void Main(string[] args)
        {
     
                Console.WriteLine("Enter the word 1:");
                StringBuilder word1 = new StringBuilder(Console.ReadLine());

                Console.WriteLine("Enter the character to search:");
                char ch = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter the word 2:");
                string word2 = Console.ReadLine();

                StringBuilder result = WordInserting(word1, ch, word2);
                Console.WriteLine(result);
        }
            
            public static StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
            {
                int position = word1.ToString().IndexOf(ch);

                
                if (position != -1)
                {
                    word1.Insert(position, word2);
                }

                // Return the modified word
                return word1;
            }
        

    }
}
