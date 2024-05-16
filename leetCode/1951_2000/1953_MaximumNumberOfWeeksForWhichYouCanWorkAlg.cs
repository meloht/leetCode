using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace leetCode._1951_2000
{
    public class _1953_MaximumNumberOfWeeksForWhichYouCanWorkAlg
    {
        public long NumberOfWeeks(int[] milestones)
        {
            int max = milestones[0];

            long total = 0;
            foreach (int item in milestones)
            {
                max = Math.Max(item, max);
                total += item;
            }

            total -= max;

            if (max > total + 1)
            {
                return total * 2 + 1;
            }
            else
            {
                return max + total;
            }
        }
    }
}
