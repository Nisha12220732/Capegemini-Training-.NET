
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your String");
        string string1 = Console.ReadLine();
        string[] str = string1.Split(" ");
        double area = 0;
        try
        {
            if (str.Length > 2)
            {
                throw new StringInvalidException("Invalid String Entered");

            }
            else if (str[0] == "C")
            {
                Console.WriteLine("This is a Circle");
                if (Int32.TryParse(str[1], out int r))
                {
                    area = 3.14 * r * r;
                }
                else
                {
                    throw new StringInvalidException("Invalid String Entered");
                }
            }

            else if (str[0] == "R")
            {
                Console.WriteLine("This is a Rectangle");

                if(str.Length > 3){
                    throw new StringInvalidException("Invalid String Entered");

                }
                else if (Int32.TryParse(str[1], out int w) && Int32.TryParse(str[2], out int h))
                {
                    area = w * h;
                }
                else
                {
                    throw new StringInvalidException("Invalid String Entered");
                }

            }

            else if (str[0] == "T")
            {
                Console.WriteLine("This is a Triangle");

                if (str.Length > 3)
                {
                    throw new StringInvalidException("Invalid String Entered");

                }
                else if (Int32.TryParse(str[1], out int b) && Int32.TryParse(str[2], out int h))
                {
                    area = 0.5 * b * h;
                }
                else
                {
                    throw new StringInvalidException("Invalid String Entered");
                }


            }

            else
            {
                throw new StringInvalidException("Invalid String Entered");
            }

            Console.WriteLine($"Area is: {area}");
        }
        catch (StringInvalidException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        catch (Exception e)
        {
            Console.WriteLine($"Error:  {e.Message}");
        }
    }

        public class StringInvalidException : Exception
        {
        public StringInvalidException(string message) : base(message)
        {
        }

        }
}




