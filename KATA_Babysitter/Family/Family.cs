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
        public DateTime startTime = new DateTime(2019, 5, 3, 17, 0 , 0);
        public DateTime EndTime = new DateTime(2019, 5, 3, 4, 0, 0);
        

        public Family()
        {

        }

        public Family(string name)
        {
            Name = name;
        }

        public Family(string name, int ratePerHour)
        {
            Name = name;
            RatePerHour = ratePerHour;
        }



    }

}
