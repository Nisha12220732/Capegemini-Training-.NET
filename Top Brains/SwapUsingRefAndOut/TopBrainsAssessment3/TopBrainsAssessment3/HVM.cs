using System;
using System.Collections.Generic;
using System.Text;

namespace TopBrainsAssessment3
{
    public class HVM : Vehicle
    {
        public int noOfWheels;
        public HVM(int wheels) : base(wheels) 
        {   
            noOfWheels = wheels;
        }

        public override void Drive()
        {
            Console.WriteLine($"{noOfWheels} wheeler driving");
        }
    }
}
