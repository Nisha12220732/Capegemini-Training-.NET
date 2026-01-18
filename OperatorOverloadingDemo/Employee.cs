class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public int Salary { get; set; }

    //Operator Overlading
    public static Employee operator + (Employee e1 , Employee e2)
    {
        Employee temp = new Employee();
        temp.Salary =  e1.Salary + e2.Salary;
        // temp.tea = e1.tea + e2.tea;
        return temp;
    }

}