using System;
using System.Collections.Generic;
using System.Text;

//T05 Team 11
//Gerald Tan Yuan Xin S10196210C
//Lim Dao Jun S10195591K

namespace PRG2_Assignment_Team11
{
    abstract class Bed
    {
        public int WardNo { get; set; }
        public int BedNo { get; set; }
        public double DailyRate { get; set; }
        public bool Available { get; set; }

        public Bed() { }

        public Bed(int w, int b, double d, bool a)
        {
            WardNo = w;
            BedNo = b;
            DailyRate = d;
            Available = a;
        }

        public abstract double CalculateCharges(string cs, int nod);

        public override string ToString()
        {
            return "WardNo: " + WardNo +
                "\tBedNo: " + BedNo +
                "\tDaily Rate: " + DailyRate +
                "\tAvailable; " + Available;
        }
    }
}
