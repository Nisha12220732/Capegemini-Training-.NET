using System;
namespace DigitalPettyCash
{
    public abstract class Transaction : IReportable
    {
        public int Id {get;set;}
        public DateTime Date { get; set; }
        public float  Amount { get; set; }
        public string Description { get; set; }

        public Transaction(int id, DateTime date, float amount, string desc)
        {
            Id = id;
            Date = date;
            this.Amount = amount;
            Description = desc;
        }

        public abstract void GetSummary();
    }
}