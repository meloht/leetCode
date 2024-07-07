using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _458_PoorPigsAlg
    {
        public int PoorPigs1(int buckets, int minutesToDie, int minutesToTest)
        {
            int times = minutesToTest / minutesToDie;
            int baseNum = times + 1;
            // base ^ ans >= buckets 
            // ans >= log(buckets) / log(base)
            double temp = Math.Log(buckets) / Math.Log(baseNum);
            int ans = (int)Math.Ceiling(temp);
            return ans;

        }

        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            int states = minutesToTest / minutesToDie + 1;
            int pigs = (int)Math.Ceiling(Math.Log(buckets) / Math.Log(states) - 1e-5);
            return pigs;
        }

    }
}
