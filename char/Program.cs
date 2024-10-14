namespace char1;

public class Program
{
    public void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
    {
        HashSet<char> seenCharacters = new HashSet<char>();

        for (int i = 0; i < chars.Length; i++)
        {
            char currentChar = char.ToUpper(chars[i]); 

            if (seenCharacters.Contains(currentChar))
            {
                chars[i] = specialChar;
            }
            else
            {
                
                seenCharacters.Add(currentChar);
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array size:");
        int arraySize = int.Parse(Console.ReadLine());

        char[] characters = new char[arraySize];

 
        Console.WriteLine("Enter the characters:");
        for (int i = 0; i < arraySize; i++)
        {
            characters[i] = char.Parse(Console.ReadLine());
        }


        Console.WriteLine("Enter the special character:");
        char specialCharacter = char.Parse(Console.ReadLine());
  
        Program program = new Program();

        program.ReplaceDuplicateWithSpecialChar(ref characters, specialCharacter);

        Console.WriteLine("Modified array:");
        foreach (char ch in characters)
        {
            Console.WriteLine(ch);
        }


        Console.WriteLine("string: " + new string(characters));
    }
}
