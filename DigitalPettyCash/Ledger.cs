using System;
using System.Collections.Generic;
using System.Transactions;
namespace DigitalPettyCash{
public class Ledger<T> where T : Transaction
{
    List<T> transactions = new List<T>();

    public void AddEntry(T trans1)
    {
        transactions.Add(trans1);
    }

    public List<Transaction> GetTransactionsByDate(DateTime date)
    {
        List<Transaction> ansList = new List<Transaction>();
        foreach(Transaction t in transactions)
        {
            if(t.Date == date)
            {
                ansList.Add(t);
            }
        }
        return ansList;
    }

    public double CalculateTotalTransactions()
    {
        double Total = 0;
        foreach(Transaction t in transactions)
        {
            Total += t.Amount;
        }
        return Total;
    }
}
}