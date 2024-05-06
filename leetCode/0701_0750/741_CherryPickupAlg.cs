﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _741_CherryPickupAlg
    {
        public int CherryPickup(int[][] grid)
        {
            int n = grid.Length;
            int[,,] f = new int[n * 2 - 1, n, n];
            for (int i = 0; i < n * 2 - 1; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    for (int k = 0; k < n; ++k)
                    {
                        f[i, j, k] = int.MinValue;
                    }
                }
            }
            f[0, 0, 0] = grid[0][0];
            for (int k = 1; k < n * 2 - 1; ++k)
            {
                for (int x1 = Math.Max(k - n + 1, 0); x1 <= Math.Min(k, n - 1); ++x1)
                {
                    int y1 = k - x1;
                    if (grid[x1][y1] == -1)
                    {
                        continue;
                    }
                    for (int x2 = x1; x2 <= Math.Min(k, n - 1); ++x2)
                    {
                        int y2 = k - x2;
                        if (grid[x2][y2] == -1)
                        {
                            continue;
                        }
                        int res = f[k - 1, x1, x2]; // 都往右
                        if (x1 > 0)
                        {
                            res = Math.Max(res, f[k - 1, x1 - 1, x2]); // 往下，往右
                        }
                        if (x2 > 0)
                        {
                            res = Math.Max(res, f[k - 1, x1, x2 - 1]); // 往右，往下
                        }
                        if (x1 > 0 && x2 > 0)
                        {
                            res = Math.Max(res, f[k - 1, x1 - 1, x2 - 1]); // 都往下
                        }
                        res += grid[x1][y1];
                        if (x2 != x1)
                        { // 避免重复摘同一个樱桃
                            res += grid[x2][y2];
                        }
                        f[k, x1, x2] = res;
                    }
                }
            }
            return Math.Max(f[n * 2 - 2, n - 1, n - 1], 0);

        }
    }
}
