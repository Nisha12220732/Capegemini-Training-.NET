
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<String, long> itemDetails = new Dictionary<String, long>()
        {
            { "Pen", 120 },
            { "Pencil", 80 },
            { "Notebook", 250 },
            { "Eraser", 60 }
        };

        Dictionary<String, long> FindItemDetails(long soldCount)
        {
          var details = ( from i in itemDetails
                          where i.Value == soldCount
                          select i).ToDictionary( i=>i.Key, i=>i.Value );

            return details;
         }

        List<String> FindMinandMaxSoldItems()
        {
            List<String> lis = new List<String>();
            var min = itemDetails.OrderBy(a => a.Value).First();
            var max = itemDetails.OrderByDescending(a =>a.Value).First();
            lis.Add(min.Key);
            lis.Add(max.Key);
            return lis;
        }

        void SortByCount()
        {
            var lis = from i in itemDetails
                      orderby i.Value descending
                      select i;
            foreach ( var item in lis)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
        Console.Write("Enter sold count to search: ");
        long soldCount = long.Parse(Console.ReadLine());

        var found = FindItemDetails(soldCount);
        if (found.Count == 0)
        {
            Console.WriteLine("Invalid sold count");
        }
        else
        {
            foreach (var kv in found)
                Console.WriteLine($"{kv.Key} : {kv.Value}");
        }
        var minMax = FindMinandMaxSoldItems();
        if (minMax.Count >= 2)
            Console.WriteLine($"Min Sold Item: {minMax[0]}, Max Sold Item: {minMax[1]}");

        Console.WriteLine("Sorted by sold count:");
        SortByCount();

    }

}
