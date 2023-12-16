using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _120_TriangleAlg
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
        
            int[] dp = new int[triangle.Count];
            dp[0] = triangle[0][0];
            int[] dpTem = new int[triangle.Count];
            IList<int> firstRow = triangle[0];
            for (int i = 1; i < triangle.Count; i++)
            {
                var arr = triangle[i];
               
                for (int j = 0; j < dpTem.Length; j++)
                {
                    dpTem[j] = int.MaxValue;
                }
                for (int n = 0; n < firstRow.Count; n++)
                {
                    int end = n + 1;
                    for (int j = n; j < arr.Count && j <= end; j++)
                    {
                        if (dpTem[j] == int.MaxValue)
                        {
                            dpTem[j] = arr[j] + dp[n];
                        }
                        else
                        {
                            dpTem[j] = Math.Min(arr[j] + dp[n], dpTem[j]);
                        }
                    }
                }
                for (int j = 0; j < dpTem.Length; j++)
                {
                    dp[j] = dpTem[j];
                }
                firstRow = arr;
            }
            int min = int.MaxValue;
            for (int i = 0; i < dp.Length; i++)
            {
                min = Math.Min(dp[i], min);
            }

            return min;
        }
    }
}
