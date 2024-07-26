using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2740_FindTheValueOfThePartitionAlg
    {
        public int FindValueOfPartition(int[] nums)
        {
            Array.Sort(nums);
            int ans = int.MaxValue;
            for (int i = 1; i < nums.Length; i++)
            {
                int n1 = nums[i - 1];
                int n2 = nums[i];
                ans = Math.Min(ans, Math.Abs(n2 - n1));
            }
            return ans;
        }
    }
}
