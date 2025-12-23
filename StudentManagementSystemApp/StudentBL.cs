using System;
using System.Linq.Expressions;
using System.Xml.Schema;
namespace StudentManagementSystemApp;


    public class StudentBL
    {
        Student sObj = null;
        public StudentBL()
        {
            sObj = new Student();
        }

        public void AcceptStudentDetails()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            try
            {
            System.Console.WriteLine("Student Management System");
            System.Console.WriteLine("***************************************");
            System.Console.WriteLine("Enter your Rollno :");
            sObj.Rollno = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Name :");
            sObj.Name = Console.ReadLine();

            System.Console.WriteLine("Enter your Address :");
            sObj.Address = Console.ReadLine();

            System.Console.WriteLine("Enter your Physics Marks :");
            sObj.Phy = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Maths Marks :");
            sObj.Maths = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Chemistry Marks :");
            sObj.Chem = Int32.Parse(Console.ReadLine());
            }
            catch(InvalidMarksException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.White;

                System.Console.WriteLine(e.Message);
            }

        }
    
        public int CalcTotal()
    {
        sObj.Total = sObj.Chem + sObj.Maths + sObj.Phy;
        return sObj.Total;
    }

    public float CalcAvg ()
    {
        sObj.Perc = sObj.Total /3;
        return sObj.Perc;
    }
     public void CalcResult(out int myTotal, out float myPerc)
    {
        myTotal = sObj.Chem + sObj.Maths + sObj.Phy;
        myPerc = myTotal/3;
    }
    }
