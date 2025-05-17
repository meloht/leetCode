using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3337_TotalCharactersInStringAfterTransformationsIIAlg
    {
        private const int MOD = 1000000007;
        public int LengthAfterTransformations(string s, int t, IList<int> nums)
        {
            int size = 26;
            int[][] f0 = new int[size][];
            for (int i = 0; i < size; i++)
            {
                f0[i] = [1];
            }

            int[][] m = new int[size][];

            for (int i = 0; i < size; i++)
            {
                int c = nums[i];
                m[i] = new int[size];
                for (int j = i + 1; j <= i + c; j++)
                {
                    m[i][j % size] = 1;
                }

            }
            int[][] mt = powMul(m, t, f0);

            int[] cnt = new int[size];
            foreach (char c in s)
            {
                cnt[c - 'a']++;
            }

            long ans = 0;
            for (int i = 0; i < size; i++)
            {
                ans += (long)mt[i][0] * cnt[i];
            }
            return (int)(ans % MOD);

        }

        // a^n * f0
        private int[][] powMul(int[][] a, int n, int[][] f0)
        {
            int[][] res = f0;
            while (n > 0)
            {
                if ((n & 1) > 0)
                {
                    res = mul(a, res);
                }
                a = mul(a, a);
                n >>= 1;
            }
            return res;
        }

        // 返回矩阵 a 和矩阵 b 相乘的结果
        private int[][] mul(int[][] a, int[][] b)
        {
            int[][] c = new int[a.Length][];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = new int[b[0].Length];

                for (int k = 0; k < a[i].Length; k++)
                {
                    if (a[i][k] == 0)
                    {
                        continue;
                    }
                    for (int j = 0; j < b[k].Length; j++)
                    {
                        c[i][j] = (int)((c[i][j] + (long)a[i][k] * b[k][j]) % MOD);
                    }
                }
            }
            return c;
        }
    }
}
