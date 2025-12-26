using System;
namespace CrazyConstructors

{
    public class Book
    {
        string title;
        string author ;
        int numPages;
        DateTime dueDate;
        DateTime returnedDate;

        public Book()
        {
            title = null;
            author = null;
            numPages = 0;
            dueDate = DateTime.MinValue;
            returnedDate = DateTime.MinValue;
        }

        public Book(string name, string author_name, int pages,DateTime dueDate, DateTime returnDate)
        {
            this.title = name;
            this.author = author_name;
            this.numPages = pages;
            this.dueDate = dueDate;
            this.returnedDate = returnDate;
        }

        public string Title
        {
            get { return title; }
        }
        public double AveragePagesReadPerDay()
        {
            int daysToRead = (returnedDate - dueDate).Days;
            double avgRead = (double)numPages/daysToRead;
            return avgRead;
        }

        public double CalculateLateFee(int dailyLateFeeRate)
        {
            int NumberOfDaysLate = (returnedDate - dueDate).Days;
            double LateFee = NumberOfDaysLate * dailyLateFeeRate;
            return LateFee;
        }
    }
}