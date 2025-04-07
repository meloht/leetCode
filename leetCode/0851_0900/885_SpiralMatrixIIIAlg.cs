using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _885_SpiralMatrixIIIAlg
    {

        public int[][] SpiralMatrixIII1(int rows, int cols, int rStart, int cStart)
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


        public int[][] SpiralMatrixIII2(int rows, int cols, int rStart, int cStart)
        {
            int total = rows * cols;
            int[][] mat = new int[total][];
            int count = 0;
            mat[count++] = [rStart, cStart];
            int bottom = rStart;
            int top = rStart;
            int left = cStart;
            int right = cStart;

            int ii = cStart;
            int jj = rStart;

            while (count < total)
            {
                ii++;
                right++;
                for (; ii <= right;)
                {
                    if (ii >= 0 && ii < cols && jj >= 0 && jj < rows)
                    {
                        mat[count] = [jj, ii];
                        if (count == total)
                            return mat;

                        count++;
                    }
                    if (ii >= right)
                    {
                        break;
                    }
                    ii++;
                }
                jj++;
                bottom++;
                for (; jj <= bottom;)
                {
                    if (jj >= 0 && jj < rows && ii >= 0 && ii < cols)
                    {
                        mat[count] = [jj, ii];
                        if (count == total)
                            return mat;

                        count++;
                    }
                    if (jj >= bottom)
                    {
                        break;
                    }
                    jj++;
                }
                ii--;
                left--;
                for (; ii >= left;)
                {
                    if (ii >= 0 && ii < cols && jj >= 0 && jj < rows)
                    {
                        mat[count] = [jj, ii];
                        if (count == total)
                            return mat;

                        count++;
                    }
                    if (ii <= left)
                    {
                        break;
                    }
                    ii--;
                }
                jj--;
                top--;
                for (; jj >= top;)
                {
                    if (jj >= 0 && jj < rows && ii >= 0 && ii < cols)
                    {
                        mat[count] = [jj, ii];
                        if (count == total)
                            return mat;

                        count++;
                    }

                    if (jj <= top)
                    {
                        break;
                    }
                    jj--;
                }
            }

            return mat;
        }


        public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            int total = rows * cols;
            int[][] mat = new int[total][];
            int count = 0;
            mat[count++] = [rStart, cStart];
            int step = 0;
            int dir = 0;
            int[][] directions = [[-1, 0], [0, 1], [1, 0], [0, -1]];
            while (count < total)
            {
                dir = (dir + 1) % 4;
                if ((dir & 1) == 1)
                {
                    step++;
                }

                for (int i = 0; i < step; i++)
                {
                    rStart += directions[dir][0];
                    cStart += directions[dir][1];

                    if (rStart >= 0 && rStart < rows && cStart >= 0 && cStart < cols)
                    {
                        mat[count++] = [rStart, cStart];

                    }
                }
            }
            return mat;
        }

    }
}
