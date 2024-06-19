using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2713_MaximumStrictlyIncreasingCellsInAMatrixAlg
    {

        public int MaxIncreasingCells(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            Dictionary<int, List<int[]>> dict = new Dictionary<int, List<int[]>>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dict.TryAdd(mat[i][j], new List<int[]>());
                    dict[mat[i][j]].Add([i, j]);

                }
            }
            int[] rowMax = new int[m];
            int[] colMax = new int[n];

            List<int> keys=dict.Keys.ToList();
            keys.Sort();
            foreach (var item in keys)
            {
                var pos = dict[item];
                List<int> res = new List<int>();
                foreach (var arr in pos)
                {
                    res.Add(Math.Max(rowMax[arr[0]], colMax[arr[1]]) + 1);
                }

                for (int i = 0; i < pos.Count; i++)
                {
                    int[] arr = pos[i];
                    int d = res[i];
                    rowMax[arr[0]] = Math.Max(rowMax[arr[0]], d);
                    colMax[arr[1]] = Math.Max(colMax[arr[1]], d);
                }
            }
          
            return rowMax.Max();
        }



    }
}
