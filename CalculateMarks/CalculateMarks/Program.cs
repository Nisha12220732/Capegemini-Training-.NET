using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            List<int> Marks = new List<int>();

            Console.WriteLine("Enter the number of subjects you want to add marks for:");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter marks for subject {i}");
                Marks.Add(Int32.Parse(Console.ReadLine()));
            }
            float GPA = 0.0f;

            if (Marks.Count <= 0)
            {
                throw new InvalidListMembersException("Your List has less than 1 elements");
            }
            else
            {
                int i = 0;
                float prodSum = 0.0f;
                foreach (int x in Marks)
                {
                    prodSum += (x * 3);
                    i++;
                }
                if (i != 0)
                {
                    GPA = prodSum / (10 * (i * 3));
                }

            }
            Console.WriteLine(GPA);
            if (GPA == 10)
            {
                Console.WriteLine("Your Grade is O");
            }
            else if (GPA >= 9 && GPA <= 10)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (GPA >= 8 && GPA <= 9)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (GPA >= 7 && GPA <= 8)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (GPA >= 6 && GPA <= 7)
            {
                Console.WriteLine("Your Grade is D");
            }
            else if (GPA >= 5 && GPA <= 6)
            {
                Console.WriteLine("Your Grade is E");
            }
            else
            {
                Console.WriteLine("OOPs You Failed the Exam!!");
            }
        }

        catch (InvalidListMembersException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

    }

    internal class InvalidListMembersException : Exception
    {
        public InvalidListMembersException()
        {

        }

        public InvalidListMembersException (string? message) : base(message)
        {

        }
    }
}
