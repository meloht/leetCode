using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _808_SoupServingsAlg
    {
        public double SoupServings(int N)
        {
            if (N > 5000)
            {
                return 1;
            }
            N = (N + 24) / 25;
            double[,] memo = new double[N + 1, N + 1];
            return Dfs(memo, N, N);
        }
        private double Dfs(double[,] memo, int A, int B)
        {
            if (A <= 0 && B <= 0)
            {
                return 0.5;
            }
            if (A <= 0)
            {
                return 1;
            }
            if (B <= 0)
            {
                return 0;
            }
            if (memo[A, B] > 0)
            {
                return memo[A, B];
            }
            memo[A, B] = 0.25 * (Dfs(memo, A - 4, B) + Dfs(memo, A - 3, B - 1) + Dfs(memo, A - 2, B - 2) + Dfs(memo, A - 1, B - 3));
            return memo[A, B];
        }
    }
}
