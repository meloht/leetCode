using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _485_MaxConsecutiveOnesAlg
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int ans = 0;
            
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int curr = nums[i];
                if (curr == 1)
                {
                    count++;
                    ans = Math.Max(ans, count);
                }
                else
                {
                    count = 0;
                }
              
            }

            return ans;
        }
    }
}
