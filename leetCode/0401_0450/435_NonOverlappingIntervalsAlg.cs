using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _435_NonOverlappingIntervalsAlg
    {
      


        public int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals.Length == 0)
                return 0;

            Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));

            int n = intervals.Length;
            int ans = 1;
            int right = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
            {

                if (intervals[i][0] >= right)
                {
                    ans++;
                    right = intervals[i][1];
                }
            }

            return n - ans;

        }

    }
}
