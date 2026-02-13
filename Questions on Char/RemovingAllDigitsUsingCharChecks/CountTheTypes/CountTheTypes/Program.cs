class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your String: ");
        string str = Console.ReadLine();
        int uppercase = 0;
        int lowercase = 0;
        int specialCharacter = 0;
        int whitespace = 0;
        int digitcount = 0;
        int punctuation = 0;
        for(int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                uppercase++ ;
            }
            if (char.IsLower(str[i]))
            {
                lowercase++;
            }
            if (char.IsWhiteSpace(str[i]))
            {
                whitespace++;
            }
            if (char.IsSymbol(str[i]))
            {
                Console.WriteLine($"Is Symbol {str[i]}");
                specialCharacter++;
            }
            if (char.IsDigit(str[i]))
            {
                digitcount++;
            }
            if (char.IsPunctuation(str[i]))
            {
                Console.WriteLine($"Is Punctuation {str[i]}");
                punctuation++;
            }

        }
        Console.WriteLine($"Number of Upper Case Character in your string is {uppercase}");
        Console.WriteLine($"Number of Lower Case Character in your string is {lowercase}");
        Console.WriteLine($"Number of  Special Character in your string is {specialCharacter}");
        Console.WriteLine($"Number of  White Space in your string is {whitespace}");
        Console.WriteLine($"Number of  Digit in your string is {digitcount}");
        Console.WriteLine($"Number of  Punctuation Marks in your string is {punctuation}");


    }
}
