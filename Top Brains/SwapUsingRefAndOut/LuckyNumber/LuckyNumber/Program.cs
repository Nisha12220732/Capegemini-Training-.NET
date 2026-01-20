class Program
{
    public static int sumOfDigits(int n)
    {
        int sum = 0;
        while(n/10 != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum + n;
    }
    public static bool luckyNumber(int num)
    {
        if(sumOfDigits(num) == (int)Math.Sqrt(sumOfDigits(num * num)))
        {
            return true; 
        }
        return false;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the range ");
        Console.Write("Starting from  ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("to ");
        int b = Int32.Parse(Console.ReadLine());

        int count = 0;
        for (int i = a; i <= b; i++)
        {
            
            if (luckyNumber(i))
            {
                Console.WriteLine($"{i} is a Lucky Number");
                count++;
            }
        }
        Console.WriteLine($"Total lucky numbers between {a} and {b} are {count}");
    }
}
