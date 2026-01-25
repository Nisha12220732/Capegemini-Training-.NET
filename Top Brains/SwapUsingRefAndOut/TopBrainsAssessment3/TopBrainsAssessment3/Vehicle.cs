using System;
using System.Collections.Generic;
using System.Text;

namespace TopBrainsAssessment3
{
    public class Vehicle
    {
        public int noOfWheels;
        public Vehicle(int wheels) 
        {
            noOfWheels = wheels;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"{noOfWheels} wheeler driving");
        }
    }
}
