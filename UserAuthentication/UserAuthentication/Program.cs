using System;
using System.Data;
class Program
{

    public class User
    {
        public string Name {  get; set; }

        public string Password { get; set; }

        public string ConfirmationPassword { get; set; }

        public void ValidatePassword (string name,string password, string confirmPassword)
        {
            if(confirmPassword == password)
            {
                Console.WriteLine("New User Created");
            }
            else
            {
                throw new PasswordMismatchException("Password entered does not match");
            }
        }
    }
    internal class PasswordMismatchException : Exception
    {
        public PasswordMismatchException()
        {

        }
        public PasswordMismatchException(string message) : base(message)
        {

        }
    }
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Create a new User");
            User newuser = new User();
            Console.WriteLine("Enter user name: ");
            newuser.Name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            newuser.Password = Console.ReadLine();
            Console.WriteLine("Confirm Password: ");
            newuser.ConfirmationPassword = Console.ReadLine();

            newuser.ValidatePassword(newuser.Name, newuser.Password, newuser.ConfirmationPassword);

        }
        catch (PasswordMismatchException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
