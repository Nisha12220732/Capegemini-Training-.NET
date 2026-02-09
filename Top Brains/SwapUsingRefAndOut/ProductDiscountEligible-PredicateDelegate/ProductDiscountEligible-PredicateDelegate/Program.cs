class Program
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool IsPremiumCustomer { get; set; }
    }

    public class DiscountEngine
    {
        public void CheckDiscount(Product product, string scheme, Predicate<Product> rule)
        {
            bool isEligible = rule(product);
            Console.WriteLine("========= DISCOUNT ELIGIBILITY =========");
            Console.WriteLine($"Product  : {product.Name}");
            Console.WriteLine($"Scheme   : {scheme}");
            Console.WriteLine($"Eligible : {isEligible}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

        }
    }

    public static void Main()
    {
        // STEP 1: Create product object (hardcoded dataset)
        Product product = new Product
        {
            ProductId = 901,
            Name = "Laptop",
            Price = 60000,
            Quantity = 12,
            IsPremiumCustomer = true
        };

        Predicate<Product> festivalDiscountRule = a => a.Price >= 5000;
        Predicate<Product> BulkDiscountRule = a => a.Quantity >= 10;
        Predicate<Product> premiumDiscountRule = a => a.IsPremiumCustomer == true;

        DiscountEngine dobj = new DiscountEngine();
        dobj.CheckDiscount(product, "Festival", festivalDiscountRule);
        dobj.CheckDiscount(product, "Bulk", BulkDiscountRule);
        dobj.CheckDiscount(product, "Premium", premiumDiscountRule);



    }
}
