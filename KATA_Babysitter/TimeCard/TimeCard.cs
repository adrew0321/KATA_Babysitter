using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATA_Babysitter
{
    public class TimeCard
    {
        public static int StartTime { get; set; }
        public static int EndTime { get; set; }
        public static int TotalHoursWorked { get; set; }
        public static int[] firstShift = { 17, 18, 19, 20, 21, 22, 23, 24 };
        public static int[] secondShift = { 1, 2, 3, 4};

        public TimeCard()
        {

        }

        public TimeCard(int startTime, int endTime)
        {
            StartTime = startTime;
            EndTime = endTime;

        }
        
        public static void CalculateWorkedHours(int startTime, int endTime)
        {

        }
        
    }
}
