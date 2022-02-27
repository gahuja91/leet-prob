using System;
using System.Collections.Generic;
using System.Text;

namespace WeeklyContest
{
    //REFERENCE: https://leetcode.com/contest/weekly-contest-282/problems/minimum-time-to-complete-trips/
    public class Trip
    {
        public long MinimumTime(int[] time, int totalTrips)
        {
            var low = 1L;
            var high = (long) 1e14;
            while (low < high)
            {
                if(Calculate(low + (high - low) / 2, time, totalTrips) != 0)
                    high = low + (high - low) / 2;
                else
                    low = low + ((high - low) / 2) + 1;
            }
            Console.WriteLine(low);
            return low;
        }

        public long Calculate(long t, int[] time, long totalTrips)
        {
            foreach(var i in time)
            {
                if ((totalTrips -= t / i) <= 0)
                    return 1;
            }
            return 0;
        }

        public void Execute()
        {
            int[] time = { 2, 3, 5 };
            int totalTrips = 10;
            MinimumTime(time, totalTrips);
        }
    }
}
