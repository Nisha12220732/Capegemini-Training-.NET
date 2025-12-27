using System;
using Assessment_QuickMart;

class Program
{
    static bool HasLastTransaction = false;
    static SaleTransaction LastTransaction;

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            DisplayMenu();
            Console.Write("Enter your option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewTransaction();
                    break;

                case "2":
                    ViewLastTransaction();
                    break;

                case "3":
                    CalculateProfitLoss();
                    break;

                case "4":
                    exit = true;
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n================ QuickMart Traders =================");
        Console.WriteLine("1. Create New Transaction");
        Console.WriteLine("2. View Last Transaction");
        Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
        Console.WriteLine("4. Exit");
    }

    static void CreateNewTransaction()
    {
        SaleTransaction txn = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        txn.InvoiceNo = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(txn.InvoiceNo))
        {
            Console.WriteLine("Invoice No cannot be empty.");
            return;
        }

        Console.Write("Enter Customer Name: ");
        txn.CustomerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        txn.ItemName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        txn.Quantity = Convert.ToInt32(Console.ReadLine());
        if (txn.Quantity <= 0)
        {
            Console.WriteLine("Quantity must be greater than zero.");
            return;
        }

        Console.Write("Enter Purchase Amount (total): ");
        txn.PurchaseAmount = Convert.ToDecimal(Console.ReadLine());
        if (txn.PurchaseAmount <= 0)
        {
            Console.WriteLine("Purchase Amount must be greater than zero.");
            return;
        }

        Console.Write("Enter Selling Amount (total): ");
        txn.SellingAmount = Convert.ToDecimal(Console.ReadLine());
        if (txn.SellingAmount < 0)
        {
            Console.WriteLine("Selling Amount cannot be negative.");
            return;
        }

        ComputeProfitLoss(txn);

        LastTransaction = txn;
        HasLastTransaction = true;

        Console.WriteLine("\nTransaction saved successfully.");
        Console.WriteLine($"Status: {txn.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {txn.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {txn.ProfitMarginPercent:F2}");
        Console.WriteLine("----------------------------------------------------");
    }

    static void ViewLastTransaction()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        PrintTransaction(LastTransaction);
    }

    static void CalculateProfitLoss()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        ComputeProfitLoss(LastTransaction);
        PrintTransaction(LastTransaction);
    }

    static void ComputeProfitLoss(SaleTransaction txn)
    {
        if (txn.SellingAmount > txn.PurchaseAmount)
        {
            txn.ProfitOrLossStatus = "PROFIT";
            txn.ProfitOrLossAmount = txn.SellingAmount - txn.PurchaseAmount;
        }
        else if (txn.SellingAmount < txn.PurchaseAmount)
        {
            txn.ProfitOrLossStatus = "LOSS";
            txn.ProfitOrLossAmount = txn.PurchaseAmount - txn.SellingAmount;
        }
        else
        {
            txn.ProfitOrLossStatus = "BREAK-EVEN";
            txn.ProfitOrLossAmount = 0;
        }

        txn.ProfitMarginPercent =
            (txn.ProfitOrLossAmount / txn.PurchaseAmount) * 100;
    }

    static void PrintTransaction(SaleTransaction txn)
    {
        Console.WriteLine("\n-------------- Last Transaction --------------");
        Console.WriteLine($"Invoice No: {txn.InvoiceNo}");
        Console.WriteLine($"Customer: {txn.CustomerName}");
        Console.WriteLine($"Item: {txn.ItemName}");
        Console.WriteLine($"Quantity: {txn.Quantity}");
        Console.WriteLine($"Purchase Amount: {txn.PurchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: {txn.SellingAmount:F2}");
        Console.WriteLine($"Status: {txn.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {txn.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {txn.ProfitMarginPercent:F2}");
        Console.WriteLine("---------------------------------------------");
    }
}
