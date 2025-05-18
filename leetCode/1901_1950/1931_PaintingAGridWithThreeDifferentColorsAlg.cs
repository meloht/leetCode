using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1901_1950
{
    public class _1931_PaintingAGridWithThreeDifferentColorsAlg
    {
        private const int mod = 1000000007;

        public int ColorTheGrid(int m, int n)
        {
            // 哈希映射 valid 存储所有满足要求的对一行进行涂色的方案
            var valid = new Dictionary<int, List<int>>();
            // 在 [0, 3^m) 范围内枚举满足要求的 mask
            int maskEnd = (int)Math.Pow(3, m);
            for (int mask = 0; mask < maskEnd; ++mask)
            {
                var color = new List<int>();
                int mm = mask;
                for (int i = 0; i < m; ++i)
                {
                    color.Add(mm % 3);
                    mm /= 3;
                }
                bool check = true;
                for (int i = 0; i < m - 1; ++i)
                {
                    if (color[i] == color[i + 1])
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    valid[mask] = color;
                }
            }

            // 预处理所有的 (mask1, mask2) 二元组，满足 mask1 和 mask2 作为相邻行时，同一列上两个格子的颜色不同
            var adjacent = new Dictionary<int, List<int>>();
            foreach (var mask1 in valid.Keys)
            {
                foreach (var mask2 in valid.Keys)
                {
                    bool check = true;
                    for (int i = 0; i < m; ++i)
                    {
                        if (valid[mask1][i] == valid[mask2][i])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        if (!adjacent.ContainsKey(mask1))
                        {
                            adjacent[mask1] = new List<int>();
                        }
                        adjacent[mask1].Add(mask2);
                    }
                }
            }

            var f = new Dictionary<int, int>();
            foreach (var mask in valid.Keys)
            {
                f[mask] = 1;
            }
            for (int i = 1; i < n; ++i)
            {
                var g = new Dictionary<int, int>();
                foreach (var mask2 in valid.Keys)
                {
                    if (adjacent.ContainsKey(mask2))
                    {
                        foreach (var mask1 in adjacent[mask2])
                        {
                            if (!g.ContainsKey(mask2))
                            {
                                g[mask2] = 0;
                            }
                            g[mask2] = (g[mask2] + f[mask1]) % mod;
                        }
                    }
                }
                f = g;
            }

            int ans = 0;
            foreach (var num in f.Values)
            {
                ans = (ans + num) % mod;
            }
            return ans;
        }

    }
}
