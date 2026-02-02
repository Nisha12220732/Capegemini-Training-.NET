namespace BikeRentalServiceConsole;
public class Bike
{
    public string Model{get;set;}
    public int PricePerDay{get;set;}
    public string Brand {get;set;}

    public Bike(string brand, string m, int price)
    {
        Model = m;
        Brand = brand;
        PricePerDay = price;
    }
    
}