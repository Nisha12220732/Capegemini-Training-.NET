using System;
using CrazyConstructors;

class Program
{
static void Main(string[] args)
{

// Book book1 = null;
System.Console.WriteLine("******** Library Management System *********");
System.Console.WriteLine("Enter Book Name : ");
string book_name = Console.ReadLine();
System.Console.WriteLine("Enter Author Name : ");
string author_name = Console.ReadLine();
System.Console.WriteLine("Enter Number of Pages in the book : ");
int nPages =Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the Due date of the book: ");
DateTime dueD = DateTime.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the Return date of the book: ");
DateTime returnD = DateTime.Parse(Console.ReadLine());

Book book1 = new Book(book_name, author_name,nPages,dueD,returnD);

double perday = book1.AveragePagesReadPerDay();
System.Console.WriteLine("Average Pages read per day : " + perday);

System.Console.WriteLine("Enter Late Fees Per day : ");
int fees =Int32.Parse(Console.ReadLine());
double latefee = book1.CalculateLateFee(fees);
System.Console.WriteLine("Late fee on book is : " + latefee);
    
            
        }
    }





