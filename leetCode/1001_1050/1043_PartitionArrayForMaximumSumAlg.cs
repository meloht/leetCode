using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1043_PartitionArrayForMaximumSumAlg
    {
        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            int n = arr.Length;
            var f = new int[k];
            for (int i = 0; i < n; ++i)
            {
                int res = 0;
                for (int j = i, mx = 0; j > i - k && j >= 0; --j)
                {
                    mx = Math.Max(mx, arr[j]); // 一边枚举 j，一边计算子数组的最大值
                                               // 注意在循环结束前，f[(i+1)%k] 是需要用到的，不能提前覆盖
                    res = Math.Max(res, f[j % k] + (i - j + 1) * mx);
                }
                f[(i + 1) % k] = res;
            }
            return f[n % k];


        }
    }
}
