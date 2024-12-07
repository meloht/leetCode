using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _688_KnightProbabilityInChessboardAlg
    {
        private static int[][] dirs = [[2, 1], [1, 2], [-1, 2], [-2, 1], [-2, -1], [-1, -2], [1, -2], [2, -1]];
        public double KnightProbability(int n, int k, int row, int column)
        {
            double[,,] memo = new double[k + 1, n, n];


            return Dfs(k,row,column,n,memo);
        }

        private double Dfs(int k, int i, int j, int n, double[,,] memo)
        {
            if (i < 0 || j < 0 || i >= n || j >= n)
            {
                return 0;
            }
            if (k == 0)
            {
                return 1;
            }
            if (memo[k, i, j] > 0)
            {
                return memo[k, i, j];
            }
            double res = 0;
            foreach (var dir in dirs)
            {
                res += Dfs(k - 1, i + dir[0], j + dir[1], n, memo);
            }
            memo[k, i, j] = res / dirs.Length;
            return memo[k, i, j];

        }
    }
}
