using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _823_BinaryTreesWithFactorsAlg
    {
        public int NumFactoredBinaryTrees(int[] arr)
        {
            long Mod = 1_000_000_007;
            Array.Sort(arr);
            int n = arr.Length;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                dict.Add(arr[i], i);
            }

            long ans = 0;
            long[] f = new long[n];

            for (int i = 0; i < n; i++)
            {
                int val = arr[i];
                f[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    int x = arr[j];
                    if ((long)x * x > val)
                    { // 防止乘法溢出
                        break;
                    }
                    if (x * x == val)
                    {
                        f[i] += f[j] * f[j];
                        break;
                    }
                    if (val % x == 0 && dict.ContainsKey(val / x))
                    {
                        f[i] += f[j] * f[dict[val / x]] * 2;
                    }
                }
                ans += f[i];
            }

            return (int)(ans % Mod);
        }
    }
}
