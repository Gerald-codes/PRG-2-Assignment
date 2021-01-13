using System;
using System.Collections.Generic;
using System.Text;

//T05 Team 11
//Gerald Tan Yuan Xin S10196210C
//Lim Dao Jun S10195591K

namespace PRG2_Assignment_Team11
{
    class Child:Patient
    {
        public double CdaBalance { get; set; }

        //public override double CalculateCharges()
        //{
        //    return DailyRate - CdaBalance; 
        //}
        public Child() { }
        public Child(string id, string na, int a, char g, string cs, string stat, double cd):base(id,na,a,g,cs,stat)
        {
            CdaBalance = cd;
        }
        public override string ToString()
        {
            return "CdaBalance:" + CdaBalance;

        }
    }
}
