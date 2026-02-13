class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your String");
        string str = Console.ReadLine();
        string newstr = "";
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (!char.IsDigit(ch))
            {
                newstr += ch;
            }
        }
        Console.WriteLine(newstr);
    }
}