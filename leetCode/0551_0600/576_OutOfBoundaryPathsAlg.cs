using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _576_OutOfBoundaryPathsAlg
    {
        public int FindPaths1(int m, int n, int maxMove, int startRow, int startColumn)
        {
            const int MOD = 1000000007;
            int[][] directions = new int[][] {
            new int[]{-1, 0},
            new int[]{1, 0},
            new int[]{0, -1},
            new int[]{0, 1}
        };
            int outCounts = 0;
            int[,,] dp = new int[maxMove + 1, m, n];
            dp[0, startRow, startColumn] = 1;
            for (int i = 0; i < maxMove; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        int count = dp[i, j, k];
                        if (count > 0)
                        {
                            foreach (int[] direction in directions)
                            {
                                int j1 = j + direction[0], k1 = k + direction[1];
                                if (j1 >= 0 && j1 < m && k1 >= 0 && k1 < n)
                                {
                                    dp[i + 1, j1, k1] = (dp[i + 1, j1, k1] + count) % MOD;
                                }
                                else
                                {
                                    outCounts = (outCounts + count) % MOD;
                                }
                            }
                        }
                    }
                }
            }
            return outCounts;

        }

        public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            const int MOD = 1000000007;
            int[][] directions = new int[][] {
            new int[]{-1, 0},
            new int[]{1, 0},
            new int[]{0, -1},
            new int[]{0, 1}
        };
            int outCounts = 0;
            int[,] dp = new int[m, n];
            dp[startRow, startColumn] = 1;
            for (int i = 0; i < maxMove; i++)
            {
                int[,] dpNew = new int[m, n];
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        int count = dp[j, k];
                        if (count > 0)
                        {
                            foreach (int[] direction in directions)
                            {
                                int j1 = j + direction[0], k1 = k + direction[1];
                                if (j1 >= 0 && j1 < m && k1 >= 0 && k1 < n)
                                {
                                    dpNew[j1, k1] = (dpNew[j1, k1] + count) % MOD;
                                }
                                else
                                {
                                    outCounts = (outCounts + count) % MOD;
                                }
                            }
                        }
                    }
                }
                dp = dpNew;
            }
            return outCounts;


        }
    }
}
