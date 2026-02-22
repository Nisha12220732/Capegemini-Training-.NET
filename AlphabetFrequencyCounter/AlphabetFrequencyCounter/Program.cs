using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your String: ");
        string str1 = Console.ReadLine();
        SortedDictionary<char, int> freq = new SortedDictionary<char, int>();
        string str = str1.ToLower();
        for (int i = 0; i < str.Length; i++)
        {
            if (freq.ContainsKey(str[i])){
                freq[str[i]]++;
            }
            else
            {
                freq.Add(str[i], 1);
            }
        }

        Console.WriteLine("Frequency of Alphabets is: ");
        foreach(var i in freq)
        {
            Console.WriteLine($"{i.Key} : {i.Value}");
        }
    }
}