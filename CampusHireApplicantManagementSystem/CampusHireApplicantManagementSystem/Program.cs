using CampusHireApplicantManagementSystem;
using System.Text.RegularExpressions;

class Program
{
    public static void DisplayMenu()
    {
        Console.WriteLine("Enter your Option: ");
        Console.WriteLine("1. Add an Applicant: ");
        Console.WriteLine("2. Display All Applicant Details");
        Console.WriteLine("3  Search Applicant by Id");
        Console.WriteLine("4. Update Current Job Location");
        Console.WriteLine("5. Update Applicant Skills");
        Console.WriteLine("6. Delete Applicant Record");
        Console.WriteLine("7. Exit");


    }

    public static bool CheckValidity(string id,string name, int year)
    {
        if(id.Length == 8 && Regex.IsMatch(id, @"^[C]{1}[H]{1}\d+\w+$"))
        {
            if(name.Length >= 4 && name.Length <= 15)
            {
                if (year == (int)DateTime.Now.Year)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        ApplicantUtility Aobj = new ApplicantUtility();
        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Add Applicant Details: ");
                        Console.WriteLine("Enter Applicant Id: ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Applicant Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Current Job Location: ");
                        CurrLocation loc1 = Enum.Parse<CurrLocation>(Console.ReadLine());
                        Console.WriteLine("Enter Job Location: ");
                        JobLocation loc2 = Enum.Parse<JobLocation>(Console.ReadLine());
                        Console.WriteLine("Enter Core Competency");
                        Competency skill =  Enum.Parse<Competency>(Console.ReadLine());
                        Console.WriteLine("Enter Passing Year");
                        int year = Int32.Parse(Console.ReadLine());

                        if (CheckValidity(id,name,year))
                        {
                            Aobj.AddNewApplicant(id, name, loc1, loc2, skill, year);
                        }
                        else
                        {
                            Console.WriteLine("Enter Valid Details");
                        }
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Applicant Details");
                        Aobj.DisplayApplicantDetails();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter Applicant Id you want to Search for ");
                        string id = Console.ReadLine();
                        Aobj.SearchById(id);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter Applicant Id you want to Update ");
                        string id = Console.ReadLine();
                        CurrLocation loc = Enum.Parse<CurrLocation>(Console.ReadLine());
                        Aobj.UpdateApplicantCurrentLocation(id, loc);
                        Console.WriteLine("Location Updated Successfully");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter Applicant Id you want to Update ");
                        string id = Console.ReadLine();
                        Competency skill = Enum.Parse<Competency>(Console.ReadLine());
                        Aobj.UpdateApplicantCompetency(id, skill);
                        Console.WriteLine("Skill Updated Successfully");
                        break;
                    }
                 case 6:
                    {
                        Console.WriteLine("Enter Applicant Id you want to Delete ");
                        string id = Console.ReadLine();
                        Aobj.DeleteApplicantRecord(id);
                        break;
                    }
                 case 7:
                    {
                        exit = true;
                        Console.WriteLine("Thank You !!");
                        Console.WriteLine("Visit Again !!");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Enter Valid Details");
                        break;
                    }

            }
        }


    }
}
