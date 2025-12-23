using System;

namespace StudentManagementSystemApp;



    public class Student
{
    float percentage;


    //CLR(common language runtime) Properties

    //Explicit (Manual) Property
    public int Rollno { set; get; }

    //Auto-Implemented Implicit Property
    public string Name{get;set;}
    public string Address{get;set;}
    public int Total { get; set; }
    public float Perc{get;set;}

    public int Phy { get; set
        {
            if (value >= 0 && value <= 100)
            {
                field = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        } }
    public int Chem { get; set
        {
            if (value >= 0 && value <= 100)
            {
                field = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        } }

    public int Maths { get; set
        {
            if (value >= 0 && value <= 100)
            {
                field = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        } }


}

[Serializable]
internal class InvalidMarksException : Exception
{
    public InvalidMarksException()
    {
    }

    public InvalidMarksException(string? message) : base(message)
    {
    }

    public InvalidMarksException(string message, Exception? innerException) : base(message, innerException)
    {
    }
}