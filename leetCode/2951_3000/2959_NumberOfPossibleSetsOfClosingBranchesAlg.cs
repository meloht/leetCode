using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2951_3000
{
    public class _2959_NumberOfPossibleSetsOfClosingBranchesAlg
    {
        public int NumberOfSets(int n, int maxDistance, int[][] roads)
        {
            int[][] g = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] row = new int[n];
                Array.Fill(row, int.MaxValue / 2); // 防止加法溢出
                g[i] = row;
            }
            foreach (int[] e in roads)
            {
                int x = e[0];
                int y = e[1];
                int wt = e[2];
                g[x][y] = Math.Min(g[x][y], wt);
                g[y][x] = Math.Min(g[y][x], wt);
            }

            int[][] f = new int[n][];
            for (int i = 0; i < n; i++)
            {
                f[i] = new int[n];
            }
            int ans = 0;
            for (int s = 0; s < (1 << n); s++)
            { // 枚举子集
                ans += Check(s, n, f, g, maxDistance);
            }
            return ans;

        }

        private int Check(int s, int n, int[][] f, int[][] g, int maxDistance)
        {
            for (int i = 0; i < n; i++)
            {
                if ((s >> i & 1) == 1)
                {
                   
                    Array.Copy(g[i], 0, f[i], 0, n);
                }
            }

            // Floyd 算法（只考虑在 s 中的节点）
            for (int k = 0; k < n; k++)
            {
                if (((s >> k) & 1) == 0) 
                    continue;
                for (int i = 0; i < n; i++)
                {
                    if (((s >> i) & 1) == 0)
                        continue;
                    for (int j = 0; j < n; j++)
                    {
                        f[i][j] = Math.Min(f[i][j], f[i][k] + f[k][j]);
                    }
                }
            }

            // 判断保留的节点之间的最短路是否均不超过 maxDistance
            for (int i = 0; i < n; i++)
            {
                if (((s >> i) & 1) == 0) 
                    continue;
                for (int j = 0; j < i; j++)
                {
                    if (((s >> j) & 1) == 1 && f[i][j] > maxDistance)
                    {
                        return 0;
                    }
                }
            }
            return 1;

        }
    }
}
