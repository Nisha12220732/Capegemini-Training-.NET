class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Password: ");
        string str = Console.ReadLine();
        int uppercase = 0;
        int lowercase = 0;
        int specialCharacter = 0;
        int digitcount = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                uppercase++;
            }
            if (char.IsLower(str[i]))
            {
                lowercase++;
            }
           
            if (char.IsSymbol(str[i]) || char.IsPunctuation(str[i]))
            {
                specialCharacter++;
            }
            if (char.IsDigit(str[i]))
            {
                digitcount++;
            }
        }
        //Console.WriteLine($"Number of Upper Case Character in your string is {uppercase}");
        //Console.WriteLine($"Number of Lower Case Character in your string is {lowercase}");
        //Console.WriteLine($"Number of  Special Character in your string is {specialCharacter}");
        //Console.WriteLine($"Number of  Digit in your string is {digitcount}");

        if(uppercase > 0 && lowercase > 0 && specialCharacter > 0 && digitcount > 0 && str.Length >= 8)
        {
            Console.WriteLine("Strong Password !!");
        }
        else
        {
            Console.WriteLine("Weak Password !!");
        }


    }
}
