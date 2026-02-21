using System.ComponentModel;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
    public static void Main(string[] args)
    {
        var products = new List<Product>()
 
        {
    new Product(){ Name="Pen", Category="Stationery", Price=10, Quantity=5 },
    new Product(){ Name="Pencil", Category="Stationery", Price=5, Quantity=10 },
    new Product(){ Name="Milk", Category="Grocery", Price=50, Quantity=2 },
    new Product(){ Name="Bread", Category="Grocery", Price=30, Quantity=1 }
        };

        var group = products.GroupBy(p => p.Category).Select(g => new
        {
            Category = g.Key,
            Count = g.Count(),
            Total = g.Sum(x=>x.Price*x.Quantity)
        });

        //DateTime date = DateTime.Parse(Console.ReadLine());
        string str = "Abc";
        string str2 = new string(str.Reverse().ToArray());
        Console.WriteLine(str2);



    }
}
