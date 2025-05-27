using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0974_SubarraySumsDivisibleByKAlg
    {
        public int SubarraysDivByK(int[] nums, int k)
        {
            int ans = 0;
            int[] map = new int[k];
            map[0] = 1;
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
                int mod = (sum % k + k) % k;
                ans += map[mod];
                map[mod]++;
            }
            return ans;
        }
    }
}
