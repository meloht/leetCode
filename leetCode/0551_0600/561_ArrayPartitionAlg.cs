using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _561_ArrayPartitionAlg
    {
        public int ArrayPairSum(int[] nums)
        {
            int ans = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i += 2)
            {
                ans += nums[i];
            }
            return ans;
        }
    }
}
