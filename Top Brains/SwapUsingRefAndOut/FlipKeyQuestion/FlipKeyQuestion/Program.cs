using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Write the String");
        string str = Console.ReadLine();
        
        if(str.Length < 6 || str.Contains(" ") || !Regex.IsMatch(str, "^[A-Za-z]+$"))
        {
            Console.WriteLine("Invalid String");
        }

        string newstr = str.ToLower();
        Console.WriteLine(newstr);

        string str2 = "";
        for(int i = 0; i < newstr.Length; i++)
        {
            if (((int)newstr[i] )% 2 != 0)
            {
                str2 += newstr[i];
            }
        }

        Console.WriteLine(str2);

        string str3 = new string(str2.Reverse().ToArray());

        Console.WriteLine(str3);

        string str4 = "";
        for(int i = 0; i < str3.Length; i++)
        {
            if (i % 2 == 0)
            {
                str4 += char.ToUpper(str3[i]);
            }
            else
            {
                str4 += str3[i];
            }
        }
        Console.WriteLine(str4);
    }
}
