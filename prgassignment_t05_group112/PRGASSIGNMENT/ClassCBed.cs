using System;
using System.Collections.Generic;
using System.Text;

//T05 Team 11
//Gerald Tan Yuan Xin S10196210C
//Lim Dao Jun S10195591K

namespace PRG2_Assignment_Team11
{
    class ClassCBed : Bed
    {
        public bool PortableTV { get; set; }

        public ClassCBed() { }
        public ClassCBed(int w, int b, double d, bool a) : base(w, b, d, a) { }


        public override double CalculateCharges(string cs, int nod)
        {
            if (PortableTV == true)
            {
                if (cs == "SC")
                {
                    return (((20 / 100.0) * 205.00 * nod) + 30.00);
                }

                else if (cs == "PR")
                {
                    return (((40 / 100.0) * 205.00 * nod) + 30.00);
                }

                else
                {
                    return (((100 / 100.0) * 205.00 * nod) + 30.00);
                }
            }

            else
            {
                if (cs == "SC")
                {
                    return ((20 / 100.0) * 205.00 * nod);
                }

                else if (cs == "PR")
                {
                    return ((40 / 100.0) * 205.00 * nod);
                }

                else
                {
                    return ((100 / 100.0) * 205.00 * nod);
                }
            }



        }

        public override string ToString()
        {
            return base.ToString() + "\tPortable TV: " + PortableTV;
        }
    }
}
