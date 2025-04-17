using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2176_CountEqualAndDivisiblePairsInAnArrayAlg
    {
        public int CountPairs(int[] nums, int k)
        {
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (nums[i] == nums[j] && (i * j) % k == 0)
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}
