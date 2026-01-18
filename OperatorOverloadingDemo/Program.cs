// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
int num1 = 100;
int num2 = 200;
int numResult = num1 + num2;

System.Console.WriteLine(numResult);

Employee emp1 = new Employee();
emp1.EmpId = 101;
emp1.EmpName = "Alok";
emp1.Salary = 100000;

Employee emp2 = new Employee();
emp1.EmpId = 102;
emp1.EmpName = "Riya";
emp1.Salary = 150000;

Employee emp3 = new Employee();
emp1.EmpId = 103;
emp1.EmpName = "Siya";
emp1.Salary = 50000;


Employee empObj = emp1 + emp2 + emp3;
System.Console.WriteLine($"Total Salary Paid: {empObj.Salary}");

