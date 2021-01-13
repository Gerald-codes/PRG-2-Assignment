using System;
using System.Collections.Generic;
using System.Text;

//T05 Team 11
//Gerald Tan Yuan Xin S10196210C
//Lim Dao Jun S10195591K

namespace PRG2_Assignment_Team11
{
    class ClassABed:Bed
    {
        public bool AccompanyingPerson { get; set; }

        public ClassABed() { }

        public ClassABed(int w, int b, double d, bool a) : base(w, b, d, a) { }
        public override double CalculateCharges(string cs, int nod)
        {
            if (AccompanyingPerson == true)
            {
                if (cs == "SC")
                {
                    return (nod * 100.00) + (100 / 100 * nod * 450.00);
                }

                else if (cs == "PR")
                {
                    return (nod * 100.00) + (100 / 100 * nod * 450.00);
                }

                else
                {
                    return (nod * 100.00) + (100 / 100 * nod * 450.00);
                }

            }

            else
            {
                if (cs == "SC")
                {
                    return (100 / 100 * nod * 450.00);
                }

                else if (cs == "PR")
                {
                    return (100 / 100 * nod * 450.00);
                }

                else
                {
                    return (100 / 100 * nod *450.00);
                }

            }

        }

        public override string ToString()
        {
            return base.ToString() + "\tAccompanyPerson: " + AccompanyingPerson;
        }
    }
}
