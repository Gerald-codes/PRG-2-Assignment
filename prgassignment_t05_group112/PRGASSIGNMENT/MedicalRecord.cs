using System;
using System.Collections.Generic;
using System.Text;

//T05 Team 11
//Gerald Tan Yuan Xin S10196210C
//Lim Dao Jun S10195591K

namespace PRG2_Assignment_Team11
{
    class MedicalRecord
    {
        public string Diagnosis { get; set; }
        public double Temperature { get; set; }
        public DateTime DatetimeEntered { get; set; }

        public MedicalRecord() { }
        public MedicalRecord(string d, double t, DateTime dt)
        {
            Diagnosis = d;
            Temperature = t;
            DatetimeEntered = dt;
        }

        public override string ToString()
        {
            return "Diagnosis: " + Diagnosis +
                "\tTemperature: " + Temperature +
                "\tEntered Datetime: " + DatetimeEntered;
        }
    }
}
