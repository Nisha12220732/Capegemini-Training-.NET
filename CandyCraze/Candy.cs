using System;
namespace CandyCraze
{
    public class Candy{
    public string Flavour {get;set;}
    public int Quantity {get; set;}
    public int PricePerPiece {get;set;}

    public double TotalPrice;
    public double Discount;

    public bool ValidateCandyFlavour()
    {
        if(Flavour  == "Strawberry"  || Flavour  == "Mint" || Flavour == "Lemon")
        {
            return true;
        }
        else
        {
            throw new InvalidFlavourException("Flavour not available");
        }
    }
    public int DiscountPercentage
    {   get
        {
        if (Flavour == "Strawberry")
            return 15;
        else if (Flavour == "Lemon")
            return 10;
        else if (Flavour == "Mint")
            return 5;
        else
            return 0;
        }
    }


    public double CalculateDiscountedPrice()
    {
        TotalPrice = Quantity *PricePerPiece;
        Discount = TotalPrice - (TotalPrice * DiscountPercentage/100);
        return Discount;
        
    }
}
internal class InvalidFlavourException :Exception
{
    public InvalidFlavourException()
    {
        
    }

    public InvalidFlavourException(string? message) :base (message)
    {
        
    }
}
}