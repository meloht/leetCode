using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3351_3400
{
    public class _3363_FindTheMaximumNumberOfFruitsCollectedAlg
    {

        public int MaxCollectedFruits(int[][] fruits)
        {
            int n = fruits.Length;
            int ans = 0;
            // 从 (0, 0) 出发的小朋友
            for (int i = 0; i < n; i++)
            {
                ans += fruits[i][i];
            }

            // 从 (0, n - 1) 出发的小朋友
            ans += dp(fruits);

            // 从 (n - 1, 0) 出发的小朋友（按照主对角线翻转）
            // 把下三角形中的数据填到上三角形中
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    fruits[j][i] = fruits[i][j];
                }
            }
            return ans + dp(fruits);
        }

        int dp(int[][] fruits)
        {
            int n = fruits.Length;
            int[,] f = new int[n - 1,n + 1];
            f[0,n - 1] = fruits[0][n - 1];
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = Math.Max(n - 1 - i, i + 1); j < n; j++)
                {
                    f[i,j] = Math.Max(Math.Max(f[i - 1, j - 1], f[i - 1, j]), f[i - 1, j + 1]) + fruits[i][j];
                }
            }
            return f[n - 2, n - 1];
        }

    }
}
