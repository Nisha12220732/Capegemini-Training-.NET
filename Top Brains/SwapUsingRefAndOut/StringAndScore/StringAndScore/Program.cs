using System;
using System.Text.Json;
class Program
{
    static List<Student> StudentList = new List<Student>();
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    public static void AddStudent(string input)
    {
        Student std = new Student();
        string[] stdarray = input.Split(':');
        std.Name = stdarray[0];
        std.Marks = Int32.Parse(stdarray[1]);
        StudentList.Add(std);
    }
    public static void Main(string[] args)
    {
 
        Console.WriteLine("Enter the number of Students you want to add");
        int n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a string in format {Name:Score}");
            string input = Console.ReadLine();
            AddStudent(input);
        }

        var result = from m in StudentList
                     orderby m.Marks descending , m.Name 
                     select m;

        foreach(Student s in result)
        {
            Console.WriteLine($"{s.Name} , {s.Marks}");
        }

        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
