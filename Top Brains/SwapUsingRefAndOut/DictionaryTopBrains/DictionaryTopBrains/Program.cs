class Program
{
    public static void Main(string[] args)
    {
        List<int> EmpId_List = new List<int>();
        Console.WriteLine("Enter the number of Employees you want ");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter the Employee ID's");
        for(int i = 0; i < n; i++)
        {
            EmpId_List.Add(Int32.Parse(Console.ReadLine()));
        }
        Dictionary<int,int> EmployeeData = new Dictionary<int,int>();
        foreach(int i in EmpId_List)
        {
            Console.WriteLine($"Enter Salary of Employee with EmployeeID {i}");
            EmployeeData.Add(i,Int32.Parse(Console.ReadLine()));
        }
        int totalSalary = 0;
        Console.WriteLine("Your Data is: ");
        foreach(KeyValuePair<int,int> i in EmployeeData)
        {
            Console.WriteLine($"EmplyeeId: {i.Key}, EmployeeSalary: {i.Value}");
            totalSalary += i.Value;
        }
        Console.WriteLine($"Total Salary of the Department is {totalSalary}");
    }
}
