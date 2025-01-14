using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3065_MinimumOperationsToExceedThresholdValueIAlg
    {
        public int MinOperations(int[] nums, int k)
        {
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < k)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
