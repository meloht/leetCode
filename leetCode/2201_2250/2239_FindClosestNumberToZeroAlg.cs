using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2239_FindClosestNumberToZeroAlg
    {
        public int FindClosestNumber(int[] nums)
        {
            int ans = 0;
            int min = int.MaxValue;
            foreach (var item in nums)
            {
                int val = Math.Abs(item);
                if (val < min)
                {
                    min = val;
                    ans = item;
                }
                else if (val == min)
                {
                    ans = Math.Max(ans, item);
                }

            }
            return ans;
        }
    }
}
