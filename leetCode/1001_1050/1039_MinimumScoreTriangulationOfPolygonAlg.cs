using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1039_MinimumScoreTriangulationOfPolygonAlg
    {
        public int MinScoreTriangulation(int[] values)
        {
            int[,] dp = new int[values.Length, values.Length];
            for (int i = values.Length - 3; i >= 0; i--)
            {
                for (int j = i + 2; j < values.Length; j++)
                {
                    int res = int.MaxValue;
                    for (int k = i + 1; k < j; k++)
                    {
                        res = Math.Min(res, dp[i, k] + dp[k, j] + values[i] * values[j] * values[k]);
                    }
                    dp[i, j] = res;
                }
            }

            return dp[0, values.Length - 1];
        }
    }
}
