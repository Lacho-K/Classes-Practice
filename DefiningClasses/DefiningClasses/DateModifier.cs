using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public double CalculateDifference(string[] d1, string[] d2)
        {
            DateTime dt1 = new DateTime(int.Parse(d1[0]), int.Parse(d1[1]), int.Parse(d1[2]));
            DateTime dt2 = new DateTime(int.Parse(d2[0]), int.Parse(d2[1]), int.Parse(d2[2]));
            return Math.Abs((dt1 - dt2).TotalDays);
        }
    }
}
