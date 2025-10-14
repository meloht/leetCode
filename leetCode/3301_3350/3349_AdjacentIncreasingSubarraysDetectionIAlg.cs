using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3349_AdjacentIncreasingSubarraysDetectionIAlg
    {
        public bool HasIncreasingSubarrays(IList<int> nums, int k)
        {
            int n = nums.Count;
            int cnt = 1, precnt = 0, ans = 0;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] > nums[i - 1])
                {
                    ++cnt;
                }
                else
                {
                    precnt = cnt;
                    cnt = 1;
                }
                ans = Math.Max(ans, Math.Min(precnt, cnt));
                ans = Math.Max(ans, cnt / 2);
            }
            return ans >= k;
        }
    }
}
