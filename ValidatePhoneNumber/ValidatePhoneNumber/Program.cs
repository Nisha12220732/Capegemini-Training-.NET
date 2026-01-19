using System;
class Program
{
    public class User
    {
        public string Name {  get; set; }
        public string PhoneNumber { get;
            set
            {
                    if (value.Length == 10)
                    {
                        field = value;
                    }
                    else
                    {
                        throw new InvalidPhoneNumberExcetion("The Phone number you entered is Invalid");
                    }
                
            }
        }
    }

    internal class InvalidPhoneNumberExcetion : Exception
    {
        public InvalidPhoneNumberExcetion()
        {

        }

        public InvalidPhoneNumberExcetion(string message) : base(message)
        {

        }
    }

    public static void Main(string[] args)
    {
        try { 
        Console.WriteLine("Create a new User");
        User newuser = new User();
        Console.WriteLine("Enter User Name");
        newuser.Name = Console.ReadLine();
        Console.WriteLine("Enter User Phone Number");
        newuser.PhoneNumber = Console.ReadLine();
        }
        catch (InvalidPhoneNumberExcetion e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
