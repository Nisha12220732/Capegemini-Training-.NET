class Program
{
    public static bool IsToggle(string str)
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
                    if (!char.IsLower(ch1))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!char.IsUpper(ch1))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        else
        {
            for (int i = 1; i < str.Length; i++)
            {
                char ch1 = str[i];
                if (i % 2 == 0)
                {
                    if (!char.IsUpper(ch1))
                    {
                        return false;
                    }
                }
                else
                {
                    if(!char.IsLower(ch1))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your String: ");
        string str = Console.ReadLine();

        Console.WriteLine($"Given String is in Toggle Case: {IsToggle(str)}");

    }
}
