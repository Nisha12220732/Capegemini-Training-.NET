using System.Data;
using System.Text.RegularExpressions;

class Program
{
    public static int AnswerAfterOperation(string str)
    {
        try
        {
            if (Regex.IsMatch(str,@"^\d+\s*[+,-,*,/,&,#,$,%]\s*\d+$")) {
                string[] operationstring = str.Split(" ");


                int op1 = Int32.Parse(operationstring[0]);

                string operation = operationstring[1];
                int op2 = Int32.Parse(operationstring[2]);



                if (operation == "+")
                {
                    return op1 + op2;
                }
                else if (operation == "-")
                {
                    return op1 - op2;
                }
                else if (operation == "*")
                {
                    return op1 * op2;
                }
                else if (operation == "/")
                {
                    if (op2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by 0");
                    }
                    else
                    {
                        return op1 / op2;
                    }
                }
                else
                {
                    throw new UnknownOperatorExpression("Please Enter a Valid Operator");
                }
            }
            else
            {
                throw new InvalidExpressionException("Expression Passed is Invalid");
            }

        }
        catch (InvalidExpressionException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (UnknownOperatorExpression e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        return 0;
    }


    internal class InvalidExpressionException : Exception
    {
        public InvalidExpressionException() { }
        public InvalidExpressionException(string message) : base(message) { }

    }
    internal class UnknownOperatorExpression : Exception
    {
        public UnknownOperatorExpression() { }
        public UnknownOperatorExpression(string message) : base(message) { }

    }
    internal class DivideByZeroException: Exception 
    {
        public DivideByZeroException() { }
        public DivideByZeroException(string message) : base(message) { }

    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Arithmetic Expression in {operand1 operation operand2} format");
        string str = Console.ReadLine();
        Console.WriteLine(AnswerAfterOperation(str));
    }
}
