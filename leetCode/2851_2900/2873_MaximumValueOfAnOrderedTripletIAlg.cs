using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2851_2900
{
    public class _2873_MaximumValueOfAnOrderedTripletIAlg
    {
        public long MaximumTripletValue(int[] nums)
        {
            long ans = 0;
            long maxDiff = 0;
            long max = 0;
            foreach (int item in nums)
            {
                ans = Math.Max(ans, maxDiff * item);
                maxDiff = Math.Max(max - item, maxDiff);
                max = Math.Max(max, item);
            }

            return ans;

        }
    }
}
