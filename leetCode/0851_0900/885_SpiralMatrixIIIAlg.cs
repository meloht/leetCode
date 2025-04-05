using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _885_SpiralMatrixIIIAlg
    {

        public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            int total = rows * cols;
            int[][] mat = new int[total][];

            int count = 0;
            int n = 2 * (rows + cols);

            int[] dr = new int[] { 0, 1, 0, -1 };
            int[] dc = new int[] { 1, 0, -1, 0 };

            mat[count++] = [rStart, cStart];

            if (total == 1)
                return mat;

            for (int k = 1; k < n; k += 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    int dk = k + (i / 2);

                    for (int j = 0; j < dk; j++)
                    {
                        rStart += dr[i];
                        cStart += dc[i];
                        if (0 <= rStart && rStart < rows && 0 <= cStart && cStart < cols)
                        {
                            mat[count++] = [rStart, cStart];
                            if (count == total)
                                return mat;
                        }
                    }
                }
            }
            return mat;
        }


    }
}
