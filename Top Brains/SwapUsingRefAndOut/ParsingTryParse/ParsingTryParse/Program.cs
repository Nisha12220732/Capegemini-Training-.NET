class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of you array");
        int n = Int32.Parse(Console.ReadLine());
        string[] arr = new string[n];
        for(int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }
        int sum = 0;
        for(int i = 0; i < n; i++)
        {
            if (int.TryParse(arr[i],out int v)){
                sum += v;

            }
        }

        Console.WriteLine(sum);

    }
}
