using System.ComponentModel.DataAnnotations;

namespace Words
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word:");
            string Word = Console.ReadLine();

            string result = "";

            Console.WriteLine("Converted word");
            for (int i = 0; i < Word.Length; i++)
            {
                
                // Check if the current character is lowercase
                if (char.IsLower(Word[i]))
                {
                    // Convert it to uppercase and add to the result
                    result += char.ToUpper(Word[i]);
                }
                // Check if the current character is uppercase
                else if (char.IsUpper(Word[i]))
                {
                    // Convert it to lowercase and add to the result
                    result += char.ToLower(Word[i]);
                }
            }
            
            Console.WriteLine(result);
        }
    }
}
