using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATA_Babysitter
{
    public class Family
    {
        public string Name { get; set; }
        public int RatePerHour { get; set; }
        public int RateAdjustment { get; set; }
        public TimeSpan startTime = new TimeSpan(17, 0, 0);
        public TimeSpan EndTime = new TimeSpan(4, 0, 0);

        public Family(string name, int ratePerHour, int rateAdjustment)
        {
            Name = name;
            RatePerHour = ratePerHour;
            RateAdjustment = RateAdjustment;
        }

    }
}
