class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your string: ");
        string str = Console.ReadLine();
        char prevChar = str[0];
        string ansstr = prevChar.ToString();
        int count = 1;
        for(int i = 1; i < str.Length; i++)
        {
            if (str[i] == prevChar)
            {
                count++;
            }
            else
            {
                ansstr += count;
                count = 1;
                ansstr += str[i];
                prevChar = str[i];
            }
        }
       
              
        ansstr += count;
        Console.WriteLine(ansstr);
    }
}