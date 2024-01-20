using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _902_NumbersAtMostNGivenDigitSetAlg
    {
        int[] dp;
        public int AtMostNGivenDigitSet(string[] digits, int n)
        {
            char[] ss = n.ToString().ToCharArray();
            int nn = ss.Length;

            int[] dinum = digits.Select(p => p[0] - '0').ToArray();

            dp = new int[nn];
            Array.Fill(dp, -1);

            int ans = Dfs(0, false, ss, dinum, true);
            return ans;
        }

        private int Dfs(int i, bool isNum, char[] s, int[] nums, bool isLimit)
        {
            if (i == s.Length)
            {
                return isNum ? 1 : 0;
            }
            if (!isLimit && isNum && dp[i] >= 0)
            {
                return dp[i];
            }
            int res = 0;
            if (!isNum)
            {
                res = Dfs(i + 1, false, s, nums, false);
            }


            int up = isLimit ? s[i] - '0' : 9;

            foreach (var item in nums)
            {
                if (item > up)
                    break;
                res += Dfs(i + 1, true, s, nums, isLimit && item == up);
            }


            if (!isLimit && isNum)
            {
                dp[i] = res;
            }
            return res;
        }
    }
}
