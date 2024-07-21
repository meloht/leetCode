using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1151_1200
{
    public class _1186_MaximumSubarraySumWithOneDeletionAlg
    {
        public int MaximumSum(int[] arr)
        {
            int n = arr.Length;
            int ans = int.MinValue;
            int[][] f = new int[n + 1][];
            for (int i = 0; i < f.Length; i++)
            {
                f[i] = [int.MinValue / 2, int.MinValue / 2];
            }
            // 除 2 防止负数相加溢出
            for (int i = 0; i < n; i++)
            {
                f[i + 1][0] = Math.Max(f[i][0], 0) + arr[i];
                f[i + 1][1] = Math.Max(f[i][1] + arr[i], f[i][0]);
                ans = Math.Max(ans, Math.Max(f[i + 1][0], f[i + 1][1]));
            }
            return ans;

        }

        public int MaximumSum1(int[] arr)
        {
            int ans = int.MinValue / 2;
            int f0 = ans;
            int f1 = ans;
            foreach (int x in arr)
            {
                f1 = Math.Max(f1 + x, f0);
                f0 = Math.Max(f0, 0) + x;
                ans = Math.Max(ans, Math.Max(f0, f1));
            }
            return ans;
        }

    }
}
