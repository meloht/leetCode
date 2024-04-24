using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1030_MatrixCellsInDistanceOrderAlg
    {
        public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
        {
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    list.Add([Math.Abs(i - rCenter) + Math.Abs(j - cCenter), i, j]);
                }
            }

            list.Sort((x, y) => x[0].CompareTo(y[0]));

            int[][] res = new int[list.Count][];
            for (int i = 0; i < list.Count; i++)
            {
                res[i] = [list[i][1], list[i][2]];
            }

            return res;
        }
    }
}
