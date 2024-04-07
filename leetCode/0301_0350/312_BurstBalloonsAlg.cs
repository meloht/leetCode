using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _312_BurstBalloonsAlg
    {
        int[][] rec;
        int[] val;
        public int MaxCoins1(int[] nums)
        {
            int len = nums.Length;
            val = new int[len + 2];
            for (int i = 1; i <= len; i++)
            {
                val[i] = nums[i - 1];
            }
            val[0] = val[len + 1] = 1;

            rec = new int[len + 2][];

            for (int i = 0; i <= len + 1; i++)
            {
                int[] arr = new int[len + 2];
                Array.Fill(arr, -1);
                rec[i] = arr;
            }

            return Dfs(0, len + 1);
        }
        private int Dfs(int left, int right)
        {
            if (left >= right - 1)
                return 0;

            if (rec[left][right] != -1)
            {
                return rec[left][right];
            }

            for (int i = left + 1; i < right; i++)
            {
                int sum = val[left] * val[i] * val[right];
                sum += Dfs(left, i) + Dfs(i, right);
                rec[left][right] = Math.Max(rec[left][right], sum);
            }
            return rec[left][right];
        }

        public int MaxCoins(int[] nums)
        {
            int n = nums.Length;
            int[,] rec = new int[n + 2, n + 2];
            int[] val = new int[n + 2];
            val[0] = val[n + 1] = 1;
            for (int i = 1; i <= n; i++)
            {
                val[i] = nums[i - 1];
            }
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = i + 2; j <= n + 1; j++)
                {
                    for (int k = i + 1; k < j; k++)
                    {
                        int sum = val[i] * val[k] * val[j];
                        sum += rec[i, k] + rec[k, j];
                        rec[i, j] = Math.Max(rec[i, j], sum);
                    }
                }
            }
            return rec[0, n + 1];

        }
    }
}
