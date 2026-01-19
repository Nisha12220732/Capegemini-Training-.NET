using System.Data;

class Program
{
    public class EcommerceShop
    {
        public string UserName { get; set; }
        public double WalletBalance { get; set; }
        public double TotalPurchaseAmount { get; set; }

        public void MakePayment(string name, double balance,double amount)
        {
            if(balance >= amount)
            {
                Console.WriteLine("Transaction Successful !!");
            }
            else
            {
                throw new InsufficientWalletBalanceException("Insufficient Balance in your digital Wallet");
            }
        }
    }

    internal class InsufficientWalletBalanceException : Exception
    {
        public InsufficientWalletBalanceException()
        {

        }
        public InsufficientWalletBalanceException(string message) : base(message)
        {

        }
    }
    public static void Main(string[] args)
    {
        try
        {
            EcommerceShop newShopee = new EcommerceShop();
            Console.WriteLine("Enter UserName");
            newShopee.UserName = Console.ReadLine();

            Console.WriteLine("Enter your Wallet Balance");
            newShopee.WalletBalance = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Total Purchase Amount");
            newShopee.TotalPurchaseAmount = Double.Parse(Console.ReadLine());
            newShopee.MakePayment(newShopee.UserName, newShopee.WalletBalance, newShopee.TotalPurchaseAmount);
            
        }

        catch(InsufficientWalletBalanceException e)
        {

            Console.WriteLine($"Error: {e.Message}");
        }

        catch (Exception e)
        {

            Console.WriteLine($"Error: {e.Message}");
        }




    }
}