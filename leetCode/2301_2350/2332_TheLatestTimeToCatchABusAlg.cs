using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2301_2350
{
    public class _2332_TheLatestTimeToCatchABusAlg
    {
        public int LatestTimeCatchTheBus(int[] buses, int[] passengers, int capacity)
        {
            Array.Sort(buses);
            Array.Sort(passengers);

            int pos = 0;
            int space = 0;

            foreach (int arrive in buses)
            {
                space = capacity;
                while (space > 0 && pos < passengers.Length && passengers[pos] <= arrive)
                {
                    space--;
                    pos++;
                }
            }

            pos--;
            int lastCatchTime = space > 0 ? buses[buses.Length - 1] : passengers[pos];
            while (pos >= 0 && passengers[pos] == lastCatchTime)
            {
                pos--;
                lastCatchTime--;
            }

            return lastCatchTime;
        }
    }
}
