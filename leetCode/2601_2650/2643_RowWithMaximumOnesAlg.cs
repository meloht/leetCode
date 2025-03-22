using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2601_2650
{
    public class _2643_RowWithMaximumOnesAlg
    {
        public int[] RowAndMaximumOnes(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            int ans = 0;
            int max = 0;
            for (int i = 0; i < m; i++)
            {
                int cnt = 0;
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 1) cnt++;
                }
                if (cnt > max)
                {
                    max = cnt;
                    ans = i;
                }
            }
            return [ans, max];
        }
    }
}
