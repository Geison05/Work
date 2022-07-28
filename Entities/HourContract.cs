﻿using System;

namespace Work.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }

        public int Hour { get; set; }


        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        public Double TotalValue()
        {
            return Hour * ValuePerHour;
        }
    }
}
