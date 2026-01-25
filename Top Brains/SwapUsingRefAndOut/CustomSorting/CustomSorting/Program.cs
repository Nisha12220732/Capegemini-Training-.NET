using System.Security.Cryptography.X509Certificates;
using CustomSorting;
class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = null;
        students = new List<Student>()
        {
            new Student{Name = "Nisha" , Age = 23 , Marks = 45},
            new Student{Name = "Nish" , Age = 21 , Marks = 40},
            new Student{Name = "Neha" , Age = 20 , Marks = 47},
            new Student{Name = "Nia" , Age = 29 , Marks = 47},
            new Student{Name = "Ni" , Age = 26, Marks = 40},
            new Student{Name = "isha" , Age = 24 , Marks = 45},
            new Student{Name = "Trisha" , Age = 19 , Marks = 50},
            
        };

        var anslist = from e in students
                      orderby e.Marks descending, e.Age 
                      select e;

        Console.WriteLine("Your Answer List is: ");

        foreach(Student student in anslist)
        {
            Console.WriteLine($"Name: {student.Name} | Age: {student.Age} | Marks: {student.Marks}");
        }


    }
}
