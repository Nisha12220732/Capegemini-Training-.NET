class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your String: ");
        string str = (Console.ReadLine()).ToLower();
        string[] str1 = str.Split(" ");
        SortedDictionary<String, int> freq = new SortedDictionary<string, int>();
        for(int i =0;i< str1.Length; i++)
        {
            if (freq.ContainsKey(str1[i]))
            {
                freq[str1[i]]++;
            }
            else
            {
                freq.Add(str1[i], 1);
            }
        }
        foreach(var i in freq)
        {
            Console.WriteLine($"{i.Key}: {i.Value}");
        }
    }
}
