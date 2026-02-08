using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConArchDemo
{
   public class Program
    {
        static void Main(string[] args)
        {
            StudentDAO dao = new StudentDAO();
            //List<Student> newList = dao.ShowAllStudents();
            //foreach(Student item in newList)
            //{
            //    Console.WriteLine($"{item.Name} \t {item.RollNo}");
            //}

            List<Student> newList2 = dao.SearchByName("Nisha");
            foreach (Student item in newList2)
            {
                Console.WriteLine($"{item.Name} \t {item.RollNo}");
            }
        }
    }
}
