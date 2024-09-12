using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2576_FindTheMaximumNumberOfMarkedIndicesAlg
    {
        public int MaxNumOfMarkedIndices(int[] nums)
        {
            Array.Sort(nums);

            int n = nums.Length;
            int l = 0, r = n / 2;
            while (l < r)
            {
                int m = l + r + 1 >> 1;
                if (Check(nums, m))
                {
                    l = m;
                }
                else
                {
                    r = m - 1;
                }
            }
            return l * 2;

        }

        public bool Check(int[] nums, int m)
        {
            int n = nums.Length;
            for (int i = 0; i < m; i++)
            {
                if (nums[i] * 2 > nums[n - m + i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
