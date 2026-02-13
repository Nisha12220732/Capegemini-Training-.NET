class Program
{
    public static string ToggleCase(string str)
    {
        char ch = str[0];
        string newstr = str[0].ToString();
        if (char.IsLower(ch))
        {
            for (int i = 1; i < str.Length; i++)
            {
                char ch1 = str[i];
                if (i % 2 == 0)
                {
                    newstr += char.ToLower(ch1);
                }
                else
                {
                    newstr += char.ToUpper(ch1);
                }
            }
        }
        else
        {
            for (int i = 1; i < str.Length; i++)
            {
                char ch1 = str[i];
                if (i % 2 == 0)
                {
                    newstr += char.ToUpper(ch1);
                     
                }
                else
                {
                    newstr += char.ToLower(ch1);
                }
            }

        }
        return newstr;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your string !!");
        string str = Console.ReadLine();

        Console.WriteLine(ToggleCase(str));

    }
}

