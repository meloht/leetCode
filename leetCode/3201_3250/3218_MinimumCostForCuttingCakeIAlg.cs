﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3218_MinimumCostForCuttingCakeIAlg
    {
        int[][][][] memo;
        int[] horizontalCut;
        int[] verticalCut;

        public int MinimumCost(int m, int n, int[] horizontalCut, int[] verticalCut)
        {
            this.memo = new int[m][][][];
            this.horizontalCut = horizontalCut;
            this.verticalCut = verticalCut;
            for (int i = 0; i < m; i++)
            {
                memo[i] = new int[n][][];
                for (int j = 0; j < n; j++)
                {
                    memo[i][j] = new int[m][];
                    for (int k = 0; k < m; k++)
                    {
                        memo[i][j][k] = new int[n];
                        Array.Fill(memo[i][j][k], -1);
                    }
                }
            }
            return DP(0, 0, m - 1, n - 1);
        }

        public int DP(int row1, int col1, int row2, int col2)
        {
            if (row1 == row2 && col1 == col2)
            {
                return 0;
            }
            if (memo[row1][col1][row2][col2] < 0)
            {
                int res = int.MaxValue;
                for (int i = row1; i < row2; i++)
                {
                    res = Math.Min(res, DP(row1, col1, i, col2) + DP(i + 1, col1, row2, col2) + horizontalCut[i]);
                }
                for (int i = col1; i < col2; i++)
                {
                    res = Math.Min(res, DP(row1, col1, row2, i) + DP(row1, i + 1, row2, col2) + verticalCut[i]);
                }
                memo[row1][col1][row2][col2] = res;
            }
            return memo[row1][col1][row2][col2];
        }

    }
}
