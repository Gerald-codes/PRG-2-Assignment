using System;
using System.Collections.Generic;
using System.Text;

//T05 Team 11
//Gerald Tan Yuan Xin S10196210C
//Lim Dao Jun S10195591K

namespace PRG2_Assignment_Team11
{
    class Adult:Patient
    {
        public double MedisaveBalance { get; set; }

        //public override double CalculateCharges()
        //{
        //    return DailyRate - MedisaveBalance;
        //}

        public Adult(string id, string na, int a, char g, string cs, string stat,  double mb) : base(id, na, a, g, cs, stat)
        {
            MedisaveBalance = mb;
        }
        public override string ToString()
        {
            return base.ToString() + "Medisave Balance: " + MedisaveBalance;

        }
    }
}
