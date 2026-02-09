
class Program
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public double Bonus { get; set; }
        public double Allowance { get; set; }
        public double Commission { get; set; }
    }



    public class SalaryEngine
    {
        public void Calculate(Employee employee, string department, Func<Employee, double> rule)
        {
            double sal = rule(employee);
            Console.WriteLine("========= SALARY CALCULATION =========");
            Console.WriteLine($"Employee Name : {employee.Name}");
            Console.WriteLine($"Department    : {department}");
            Console.WriteLine($"Salary        : {sal}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

        }
    }
    public static void Main()
    {

        Employee employee = new Employee
        {
            EmployeeId = 601,
            Name = "Ananya",
            BaseSalary = 50000,
            Bonus = 10000,
            Allowance = 8000,
            Commission = 12000
        };

        Func<Employee, double> ITSalaryRule = x => employee.BaseSalary + employee.Bonus;
        Func<Employee, double> HRSalaryRule = x => employee.BaseSalary + employee.Allowance;
        Func<Employee, double> SalesSalaryRule = x => employee.BaseSalary + employee.Commission;

        SalaryEngine sObj = new SalaryEngine();
        sObj.Calculate(employee, "IT", ITSalaryRule);
        sObj.Calculate(employee, "HR", HRSalaryRule);
        sObj.Calculate(employee, "Sales", SalesSalaryRule);
    }
}
