using System;
using System.Collections.Generic;
using System.Text;

//T05 Team 11
//Gerald Tan Yuan Xin S10196210C
//Lim Dao Jun S10195591K

namespace PRG2_Assignment_Team11
{
    class ClassBBed : Bed
    {
        public bool AirCon { get; set; }

        public ClassBBed() { }

        public ClassBBed(int w, int b, double d, bool a) : base(w, b, d, a) { }
        public override double CalculateCharges(string cs, int nod)
        {
            if (AirCon == true)
            {
                if (cs == "SC")
                {
                    return (Math.Ceiling(nod % 7.0) * 50.00) + ((30 / 100.0) * nod * 268.00);
                }

                else if (cs == "PR")
                {
                    return (Math.Ceiling(nod % 7.0) * 50.00) + ((60 / 100.0) * nod *268.00);
                }

                else
                {
                    return (Math.Ceiling(nod % 7.0) * 50.00) + ((100 / 100.0) * nod * 268.00);
                }

            }

            else
            {
                if (cs == "SC")
                {
                    return ((30 / 100.0) * nod * 268.00);
                }

                else if (cs == "PR")
                {
                    return ((60 / 100.0) * nod * 268.00);
                }

                else
                {
                    return ((100 / 100.0) * nod * 268.00);
                }

            }

        }

        public override string ToString()
        {
            return base.ToString() + "\tAirCon: " + AirCon;
        }
    }

}
