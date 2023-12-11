using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _96_UniqueBinarySearchTreesAlg
    {
        /// <summary>
        /// 卡塔兰数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumTrees(int n)
        {
            if (n < 3)
                return n;
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;
            
            int total = 0;
            int nn = 0;
            int nnn = 0;
            for (int i = 3; i <= n; i++)
            {
                nn = i - 1;
                total = 0;
                for (int j = 0; j <= nn; j++)
                {
                    nnn = nn - j;
                    int res = dp[j] * dp[nnn];
                    total += res;
                }
                dp[i] = total;

            }

            return dp[n];
        }
    }
}
