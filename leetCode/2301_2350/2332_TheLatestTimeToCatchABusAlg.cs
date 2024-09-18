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

            int max = buses[buses.Length - 1];

            for (int i = passengers.Length - 1; i >= 0; i--)
            {
                if (passengers[i] > max)
                {
                    continue;
                }
                if (i == passengers.Length - 1 && passengers[i] < max)
                {
                    return passengers[i] + 1;
                }

                if (i < passengers.Length - 1 && passengers[i + 1] - passengers[i] > 1)
                {
                    return passengers[i] + 1;
                }
            }

            return passengers[0] - 1;
        }
    }
}
