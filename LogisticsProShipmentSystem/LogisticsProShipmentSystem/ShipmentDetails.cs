using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LogisticsProShipmentSystem
{
    public class ShipmentDetails : Shipment
    {
        public bool ValidateShipmentCode(string str)
        {
            if (Regex.IsMatch(str, @"^[G]{1}[C]{1}[#]{1}[0-9]{4}"))
            {
                return true;
            }
            return false;
        }

        public double CalculateTotalCost()
        {
            double RatePerKg = 0;
            if (TransportMode.Equals("Sea"))
            {
                RatePerKg = 15.00;
            }
            else if (TransportMode.Equals("Air"))
            {
                RatePerKg = 50.00;
            }
            else if (TransportMode.Equals("Land"))
            {
                RatePerKg = 25.00;
            }
            else
            {
                throw new InvalidTransportModeException("Transport Mode is Invalid!!");
            }
            return Math.Round((Weight * RatePerKg) + Math.Sqrt(StorageDays),2);

        }

        

    }
    public class InvalidTransportModeException : Exception
    {
        public InvalidTransportModeException() : base()
        {

        }
        public InvalidTransportModeException(string str): base(str)
        {

        }
    }

}
