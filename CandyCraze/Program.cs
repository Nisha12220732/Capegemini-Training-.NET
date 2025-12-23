using System;
using System.Data;
using CandyCraze;


Candy cd = new Candy();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("*************Candy Craze***************");
System.Console.WriteLine("Enter the Flavour (Strawberry/Lemon/Mint)");
cd.Flavour= Console.ReadLine();
System.Console.WriteLine("Enter the Quantity");
cd.Quantity= Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the Price Per Piece");
cd.PricePerPiece= Int32.Parse(Console.ReadLine());
System.Console.Write("Your Total Shopping Bill is: ");
System.Console.WriteLine(cd.CalculateDiscountedPrice());
System.Console.WriteLine("******** Thank you for Shopping ********");
System.Console.WriteLine("******** Please Visit Again ********");



