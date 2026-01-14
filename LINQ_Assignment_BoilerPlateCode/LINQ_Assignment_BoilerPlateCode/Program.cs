
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Assignment_BoilerPlateCode.Repos;
using LINQ_Assignment_BoilerPlateCode.DTOs;
using LINQ_Assignment_BoilerPlateCode.Models;

namespace LINQ_Assignment_BoilerPlateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // =======================
            // SAMPLE DATA
            // =======================
            var employees = EmployeeRepo.SeedEmployees();
            var projects = ProjectRepo.SeedProjects();

            Console.WriteLine("LINQ Scenario Boilerplate Loaded");


            Console.WriteLine("High Earning Employees");
            List<Employee> tempList = GetHighEarningEmployees(employees);
            foreach (Employee e in tempList)
            {
                Console.WriteLine($"{e.Name} , {e.Id} , {e.Salary} , {e.Department}");
            }

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Employee Names");
            List<string> tempList2 = GetEmployeeNames(employees);
            foreach (string e in tempList2)
            {
                Console.WriteLine(e);
            }

            if (HasHREmployees(employees))
            {
                Console.WriteLine("Employee Data has HR employees !");
            }
            else
            {
                Console.WriteLine("Employee Data do not has HR employees !");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Highest Paid Employee is: ");
            Employee highestPaid = GetHighestPaidEmployee(employees);
            Console.WriteLine($"{highestPaid.Name} , {highestPaid.Id} ,{highestPaid.Salary},{highestPaid.Department} ");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Employees group by");
            Console.WriteLine("Solution 2.3");
            List<Employee> tempList3 = SortEmployeesBySalaryAndName(employees);
            foreach (Employee e in tempList3)
            {
                Console.WriteLine($"{e.Name} , {e.Id} , {e.Salary} , {e.Department}");
            }

            Console.WriteLine();
            Console.WriteLine();
            List<DepartmentCount> tempList4 = GetDepartmentWiseCount(employees);
            foreach (var e in tempList4)
            {
                Console.WriteLine($"{e.Count} , {e.Department}");
            }

            Console.WriteLine();
            Console.WriteLine();
            List<EmployeeProject> tempList5 = GetEmployeeProjectMappings(employees, projects);
            foreach (var e in tempList5)
            {
                Console.WriteLine($"{e.EmployeeName} , {e.ProjectName}");
            }

        }

        // =====================================================
        // 🟢 SECTION 1 – HR ANALYTICS
        // =====================================================

        // TODO 1.1: Get employees earning more than 60,000
        static List<Employee> GetHighEarningEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var empList = from emp in employees
                          where emp.Salary > 60000
                          select emp;

            return empList.ToList<Employee>();
            //throw new NotImplementedException();
        }

        // TODO 1.2: Get list of employee names only
        static List<string> GetEmployeeNames(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var empList = from emp in employees
                          select emp.Name;
            return empList.ToList<String>();
            //throw new NotImplementedException();
        }

        // TODO 1.3: Check if any employee belongs to HR department
        static bool HasHREmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var departmentList = from emp in employees
                                 select emp.Department;
            return departmentList.Contains("HR");
            //throw new NotImplementedException();
        }


        // =====================================================
        // 🟡 SECTION 2 – MANAGEMENT INSIGHTS
        // =====================================================

        // TODO 2.1: Get department-wise employee count
        static List<DepartmentCount> GetDepartmentWiseCount(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            //throw new NotImplementedException();
            var departmentcount = (from emp in employees
                                   group emp by emp.Department
                                  into g
                                   select new DepartmentCount {
                                       Department = g.Key,
                                       Count = g.Count()
                                   }).ToList();

            return departmentcount;

        }

        // TODO 2.2: Find the highest paid employee
        static Employee GetHighestPaidEmployee(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var empSalary = employees.Select(s => s.Salary).Max();
            var ans = from e in employees
                      where e.Salary == empSalary
                      select e;

            Employee anse = null;
            foreach (var emp in ans)
            {
                anse = emp;
            }
            return anse;


            //throw new NotImplementedException();
        }




        // TODO 2.3: Sort employees by Salary (DESC), then Name (ASC)
        static List<Employee> SortEmployeesBySalaryAndName(List<Employee> employees)
        {

            var sortedans = from emp in employees
                            orderby emp.Salary descending, emp.Name
                            select emp;
            return sortedans.ToList<Employee>();
            //throw new NotImplementedException();
        }



        // =====================================================
        // 🔵 SECTION 3 – PROJECT & SKILL INTELLIGENCE
        // =====================================================

        // TODO 3.1: Join employees with projects
        static List<EmployeeProject> GetEmployeeProjectMappings(
            List<Employee> employees,
            List<Project> projects)
        {
            var result = (from e in employees
                          join p in projects
                          on e.Id equals p.EmployeeId
                          select new EmployeeProject
                          {
                              EmployeeName = e.Name,
                              ProjectName = p.ProjectName
                          }).ToList();

            return result;

            //throw new NotImplementedException();
        }


    }
}
/*

        // TODO 3.2: Find employees who are NOT assigned to any project
        static List<Employee> GetUnassignedEmployees(
            List<Employee> employees,
            List<Project> projects)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 3.3: Get all unique skills across the organization
        static List<string> GetAllUniqueSkills(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // =====================================================
        // 🔴 SECTION 4 – ADVANCED WORKFORCE ANALYTICS
        // =====================================================

        // TODO 4.1: Get top 3 highest-paid employees per department
        static List<DepartmentTopEmployees> GetTopEarnersByDepartment(
            List<Employee> employees)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 4.2: Remove duplicate employees based on Id
        static List<Employee> RemoveDuplicateEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
            //List<Employee> emp = employees.Select(s => s.Department).Distinct();
            //return emp;

            var emp = from employee in employees
                      select Distinct(emp.ID);

        }

        // TODO 4.3: Implement pagination
        static List<Employee> GetEmployeesByPage(
            List<Employee> employees,
            int pageNumber,
            int pageSize = 5)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }


    }
}

*/