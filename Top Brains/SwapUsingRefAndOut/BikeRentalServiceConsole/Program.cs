using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using BikeRentalServiceConsole;

class Program
{
    public static void Main(string[] args)
    {
        BikeUtility obj = new BikeUtility();
        bool exit  = false;
        while (!exit)
        {
            DisplayMenu();
            int n = Int32.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        System.Console.WriteLine("Enter Bike Brand");
                        string brand= Console.ReadLine();
                        System.Console.WriteLine("Enter Bike Model");
                        string model = Console.ReadLine();
                        System.Console.WriteLine("Enter Bike's Rent Price Per Day");
                        int price = Int32.Parse(Console.ReadLine());
                        obj.AddBikeDetails(brand,model,price);
                       break; 
                    }

                case 2:
                    {
                        var res = obj.GroupBikesByBrand();
                        foreach (var i in res)
                        {
                            System.Console.Write($"{i.Key} : ");
                            foreach(var b in i.Value){
                            System.Console.Write($"{b}  ");
                            }
                            System.Console.WriteLine();

                        }
                        break;

                    }  
                case 3:
                    {
                        exit = true;
                        break;
                    }   

                default:
                {
                    System.Console.WriteLine("Invalid choice Entered!");
                    break;
                }
            }
        }
    }
        public static void DisplayMenu()
        {
            System.Console.WriteLine("----------------- MENU -----------------");
            System.Console.WriteLine("Enter your choice:");
            System.Console.WriteLine("1. Add a bike");
            System.Console.WriteLine("2. Group Bikes by Brand");
            System.Console.WriteLine("3. Exit");


        }
}
