using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
        public override string ToString()
        {
            return string.Format("Day: {0}, Month: {1}, Year: {2}", Day, Month, Year);
        }
    }
}
