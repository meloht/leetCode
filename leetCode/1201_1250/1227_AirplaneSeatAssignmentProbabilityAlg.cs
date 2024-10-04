using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1201_1250
{
    public class _1227_AirplaneSeatAssignmentProbabilityAlg
    {
        public double NthPersonGetsNthSeat(int n)
        {
            return n == 1 ? 1 : 0.5;
        }
    }
}
