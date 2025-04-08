using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3351_3400
{
    public class _3396_MinimumNumberOfOperationsToMakeElementsInArrayDistinctAlg
    {
        public int MinimumOperations(int[] nums)
        {
            int[] map = new int[101];

            int ans = 0;
            int idx = -1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (map[nums[i]] > 0)
                {
                    idx = i;
                    break;
                }
                map[nums[i]]++;
            }
            int n = idx + 1;
            ans = n / 3;
            if (n % 3 > 0)
            {
                ans += 1;
            }

            return ans;
        }
    }
}
