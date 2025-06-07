using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    
    public class _3191_MinimumOperationsToMakeBinaryArrayElementsEqualToOneIAlg
    {
        public int MinOperations(int[] nums)
        {
            int n = nums.Length;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                {
                    if (i > n - 3)
                    {
                        return -1;
                    }
                    nums[i] ^= 1;
                    nums[i + 1] ^= 1;
                    nums[i + 2] ^= 1;
                    ans++;
                }
            }
            return ans;
        }

    }
}
