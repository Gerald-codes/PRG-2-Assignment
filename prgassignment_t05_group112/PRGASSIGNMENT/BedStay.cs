using System;
using System.Collections.Generic;
using System.Text;

//T05 Team 11
//Gerald Tan Yuan Xin S10196210C
//Lim Dao Jun S10195591K
namespace PRG2_Assignment_Team11
{
    class BedStay
    {
        public DateTime StartBedStay{ get; set; }
        public DateTime? EndBedStay { get; set; }
        public Bed Bed { get; set; }

       

        public BedStay(DateTime s, Bed b)
        {
            StartBedStay = s;
            Bed = b;
        }

        public override string ToString()
        {
            return "Start BedStay: " + StartBedStay +
                "\tEnd BedStay: " + EndBedStay +
                "\tBed: " + Bed;
        }
    }
}
