using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1072_FlipColumnsForMaximumNumberOfEqualRowsAlg
    {
        public int MaxEqualRowsAfterFlips(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < m; i++)
            {
                char[] arr = new char[n];
                Array.Fill(arr, '0');
                for (int j = 0; j < n; j++)
                {
                    arr[j] = (char)('0' + (matrix[i][j] ^ matrix[i][0]));
                }
                string s = new string(arr);

                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict.Add(s, 1);
                }

            }
            int res = 0;
            foreach (var item in dict)
            {
                res = Math.Max(res, item.Value);
            }

            return res;
        }
    }
}
