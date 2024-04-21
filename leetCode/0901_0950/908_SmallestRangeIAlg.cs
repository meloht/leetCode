using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _908_SmallestRangeIAlg
    {
        public int SmallestRangeI(int[] nums, int k)
        {
            if (nums.Length == 1)
                return 0;

            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                min = Math.Min(min, nums[i]);
                max = Math.Max(max, nums[i]);
            }
            int dis = max - min;
            if (dis <= 2 * k)
            {
                return 0;
            }
            else
            {
                dis = max - k - (min + k);
                return dis;
            }

        }
    }
}
