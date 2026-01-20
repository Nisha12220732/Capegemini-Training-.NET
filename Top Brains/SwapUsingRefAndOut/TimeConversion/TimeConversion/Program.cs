
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Time in seconds");
        int time = Int32.Parse(Console.ReadLine());
        int sec = time % 60;
        int min = time / 60;
        if(sec < 10)
        {
            Console.WriteLine($"Time is {min}:0{sec}");
        }
        else
        {
            Console.WriteLine($"Time is {min}:{sec}");
        }
    }
}