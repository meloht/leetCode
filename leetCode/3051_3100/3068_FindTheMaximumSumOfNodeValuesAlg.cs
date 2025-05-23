using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3068_FindTheMaximumSumOfNodeValuesAlg
    {
        public long MaximumValueSum(int[] nums, int k, int[][] edges)
        {
            long f0 = 0;
            long f1 = long.MinValue;
            foreach (int x in nums)
            {
                long t = Math.Max(f1 + x, f0 + (x ^ k));
                f0 = Math.Max(f0 + x, f1 + (x ^ k));
                f1 = t;
            }
            return f0;

        }
    }
}
