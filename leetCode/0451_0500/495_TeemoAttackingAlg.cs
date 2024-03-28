using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _495_TeemoAttackingAlg
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int ans = 0;
            if (timeSeries.Length == 1)
            {
                ans += duration;
            }
            for (int i = 1; i < timeSeries.Length; i++)
            {
                int prev = timeSeries[i - 1];
                int curr = timeSeries[i];
                int dd = prev + duration - 1;
                if (dd >= curr)
                {
                    ans += (duration - (dd - curr + 1));
                }
                else
                {
                    ans += duration;
                }

            }

            if (timeSeries.Length > 1)
            {
                ans += duration;
            }

            return ans;
        }
    }
}
