using System;
using System.Collections.Generic;
using System.Text;

namespace TopBrainsAssessment3
{
    public class TwoWheeler : Vehicle
    {
        public TwoWheeler() : base(2)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("2 wheeler driving");
        }
    }
}
