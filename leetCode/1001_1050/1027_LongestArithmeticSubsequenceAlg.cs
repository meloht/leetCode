using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1027_LongestArithmeticSubsequenceAlg
    {
        public int LongestArithSeqLength(int[] nums)
        {
            int ans = 0;
            int m = nums.Max();
           
            for (int d = -m; d <= m; d++)
            {
                int[] f = new int[m + 1];
                foreach (int x in nums)
                {
                    f[x] = 0 <= x - d && x - d <= m ? f[x - d] + 1 : 1;
                    ans = Math.Max(ans, f[x]);
                }
            }
            return ans;

        }
    }
}
