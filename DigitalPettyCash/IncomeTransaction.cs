using System;
namespace DigitalPettyCash
{
    public class IncomeTransaction : Transaction
    {
        public string Source { get; set; }
        public IncomeTransaction(int id,DateTime date, float amount, string desc, string source): base(id, date, amount, desc)
        {
            Source = source;
        }

        public override void GetSummary()
        {
            System.Console.WriteLine("Transaction Id is {0}\n Transaction Date is {1}\n Transaction Amount is {2}\n Transaction Description is {3}\n Transaction Source is {4}\n", Id,Date,Amount,Description,Source);
        }
    }
}