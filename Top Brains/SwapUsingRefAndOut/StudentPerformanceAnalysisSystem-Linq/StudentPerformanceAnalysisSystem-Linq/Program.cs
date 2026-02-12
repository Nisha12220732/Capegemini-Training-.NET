using System.Linq;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}
public class Solution
{
    public static void Main(string[] args)
    {
        List<Student> newList = new List<Student>()
        {
            new Student(){StudentId = 101, Name = "Ananya" , Marks = 78},
            new Student(){StudentId = 102, Name = "Ravi" , Marks = 45},
            new Student(){StudentId = 103, Name = "Neha" , Marks = 88},
            new Student(){StudentId = 104, Name = "Arjun" , Marks = 67}
        };

        Console.WriteLine("Passed Students:");
        var lis = from i in newList
                  where i.Marks >= 50
                  select i;

        foreach (var i in lis)
        {
            Console.WriteLine($"{i.Name}");
        }
        Console.WriteLine();

        int highestMarks = newList.Select(a => a.Marks).Max();
        var lis2 = from i in newList
                   where i.Marks == highestMarks
                   select i;
        Console.WriteLine("Topper:");
        foreach (var i in lis2)
        {
            Console.WriteLine($"{i.Name} - {i.Marks}");

        }
        Console.WriteLine();


        var lis3 = from i in newList
                   orderby i.Marks descending
                   select i;

        Console.WriteLine("Students Sorted by Marks:");
        foreach (var i in lis3)
        {
            Console.WriteLine($"{i.Name} - {i.Marks}");

        }
        Console.WriteLine();

    }
}