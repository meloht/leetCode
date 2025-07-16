using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3201_FindTheMaximumLengthOfValidSubsequenceIAlg
    {
        public int MaximumLength(int[] nums)
        {
            int ans = 0;
            for (int m = 0; m < 2; m++)
            {
                int[] f = new int[2];

                foreach (int item in nums)
                {
                    int x = item;
                    x %= 2;
                    f[x] = f[(m - x + 2) % 2] + 1;
                    ans = Math.Max(ans, f[x]);
                }
            }
            return ans;

        }
    }
}
