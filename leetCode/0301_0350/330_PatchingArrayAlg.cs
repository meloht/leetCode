using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _330_PatchingArrayAlg
    {
        public int MinPatches(int[] nums, int n)
        {
            Array.Sort(nums);
            long total = 1;
            long i = 0;
            int count = 0;
            while (total <= n)
            {
                if (i < nums.Length && nums[i] <= total)
                {
                    total += nums[i];
                    i++;
                }
                else
                {
                    total = total * 2;
                    count++;
                }
            }

            return count;
        }
    }
}
