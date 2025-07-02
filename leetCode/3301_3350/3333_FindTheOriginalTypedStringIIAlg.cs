using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3333_FindTheOriginalTypedStringIIAlg
    {
        public int PossibleStringCount(string word, int k)
        {
            int n = word.Length;
            if (n < k)
                return 0;
            int mod = 1_000_000_007;
            List<int> cnts = new List<int>();
            long ans = 1;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                cnt++;
                if (i == n - 1 || word[i] != word[i + 1])
                {
                    if (cnt > 1)
                    {
                        if (k > 0)
                        {
                            cnts.Add(cnt - 1);
                        }
                        ans = ans * cnt % mod;
                    }
                    k--;
                    cnt = 0;
                }
            }
            if (k <= 0)
            {
                return (int)ans;
            }
            int m = cnts.Count;
            int[][] f = new int[m + 1][];
            for (int i = 0; i < f.Length; i++)
            {
                f[i] = new int[k];
            }
            Array.Fill(f[0], 1);
            int[] s = new int[k + 1];
            for (int i = 0; i < m; i++)
            {
                // 计算 f[i] 的前缀和数组 s
                for (int j = 0; j < k; j++)
                {
                    s[j + 1] = (s[j] + f[i][j]) % mod;
                }
                int c = cnts[i];
                // 计算子数组和
                for (int j = 0; j < k; j++)
                {
                    f[i + 1][j] = (s[j + 1] - s[Math.Max(j - c, 0)]) % mod;
                }
            }

            return (int)((ans - f[m][k - 1] + mod) % mod); // 保证结果非负

        }
    }
}
