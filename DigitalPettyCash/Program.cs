using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Timers;
using System.Xml;
using Microsoft.VisualBasic;
using DigitalPettyCash;

class Program
{
    static void Main()
    {
        Ledger<Transaction> ledger = new Ledger<Transaction>();

        void DisplayMenu(){
            System.Console.WriteLine("Enter your Choice: ");
            System.Console.WriteLine("1. Add Entry in the Ledger");
            System.Console.WriteLine("2. Search Entry by Date");
            System.Console.WriteLine("3. Return the Total Amount");
            System.Console.WriteLine("4. Exit");
        }
        bool exit = false;

        while (!exit)
        {
            DisplayMenu();
            Console.Write("Enter your option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddNewTransaction();
                    break;

                case "2":
                    SearchTransactionByDate();
                    break;

                case "3":
                    Calculatetotal();
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

        void AddNewTransaction()
        {
            Console.WriteLine("Enter the type of Transaction:");
            System.Console.WriteLine("1. Income Transaction");
            System.Console.WriteLine("2. Expense Transaction");
            int transactiontype = Int32.Parse(Console.ReadLine());
            if(transactiontype == 1)
            {
                System.Console.WriteLine("Enter TransactionID: ");
                int id =  Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter Transaction Amount: ");
                float amt =  float.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter Description: ");
                string desc =  Console.ReadLine();
                System.Console.WriteLine("Enter source (Main Cash or Bank Transfer): ");
                string source =  Console.ReadLine();
                ledger.AddEntry(new IncomeTransaction(id,DateTime.Now,amt,desc,source));
            }
            else if(transactiontype == 2)
            {
                System.Console.WriteLine("Enter TransactionID: ");
                int id =  Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter Transaction Amount: ");
                float amt =  float.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter Description: ");
                string desc =  Console.ReadLine();
                System.Console.WriteLine("Enter Category (Office/Travel/Food): ");
                string source =  Console.ReadLine();
                ledger.AddEntry(new ExpenseTransaction(id,DateTime.Now,amt,desc,source));
            }
            else
            {
                System.Console.WriteLine("Not a valid Transaction Type");
            }       
        }

        void SearchTransactionByDate()
        {
            Console.WriteLine("Enter the Date of Transaction you want to search for:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine(ledger.GetTransactionsByDate(date));
        }

        void Calculatetotal()
        {
            System.Console.WriteLine(ledger.CalculateTotalTransactions());
        }

    }
}

