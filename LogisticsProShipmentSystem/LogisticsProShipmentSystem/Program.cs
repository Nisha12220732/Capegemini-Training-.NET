using LogisticsProShipmentSystem;
using System;
class Program
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Enter Shipment Code: ");
        string shipmentcode = Console.ReadLine();

        ShipmentDetails sObj = new ShipmentDetails();
        //ShipmentDetails sObj = new ShipmentDetails();


        if (!sObj.ValidateShipmentCode(shipmentcode))
        {
            Console.WriteLine("Invalid Shipment Code");
        }
        else
        {
            Console.WriteLine("Enter Transport Mode: ");
            string mode = Console.ReadLine();
            Console.WriteLine("Enter Weight of Shipment");
            double weight = Int32.Parse(Console.ReadLine());
            Console.WriteLine("No. of Storage Days");
            int days = Int32.Parse(Console.ReadLine());

            sObj.ShipmentCode = shipmentcode;
            sObj.TransportMode = mode;   
            sObj.Weight = weight;
            sObj.StorageDays = days;

            Console.WriteLine($"The total shipping cost is {sObj.CalculateTotalCost()}");
        }

    }
}
