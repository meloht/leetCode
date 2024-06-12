using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0401_0450
{
    public class _410_SplitArrayLargestSumAlg
    {

        public int SplitArray1(int[] nums, int k)
        {
            int[] sums = new int[nums.Length + 1];
            sums[0] = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sums[i + 1] = sums[i] + nums[i];
            }
            int n = nums.Length;

           
            int ans = Dfs(nums, k, 0, 0, sums);
            return ans;
        }

        private int Dfs(int[] nums, int k, int idx, int max, int[] sums)
        {
            if (k == 1)
            {
                int num = sums[nums.Length] - sums[idx];

                return Math.Max(num, max);
            }

            int end = nums.Length - k;
            int nn = 0;
            int ans = int.MaxValue;
            for (int i = idx; i <= end; i++)
            {
                nn += nums[i];

                int num = Dfs(nums, k - 1, i + 1, Math.Max(nn, max), sums);
                ans = Math.Min(ans, num);
            }
          
            return ans;
        }

        public int SplitArray(int[] nums, int k)
        {
            int n = nums.Length;
            int[,] f = new int[n + 1,k + 1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    f[i, j] = int.MaxValue;
                }
               
            }
            int[] sub = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                sub[i + 1] = sub[i] + nums[i];
            }
            f[0,0] = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= Math.Min(i, k); j++)
                {
                    for (int h = 0; h < i; h++)
                    {
                        f[i,j] = Math.Min(f[i, j], Math.Max(f[h, j - 1], sub[i] - sub[h]));
                    }
                }
            }
            return f[n, k];
        }

    }
}
