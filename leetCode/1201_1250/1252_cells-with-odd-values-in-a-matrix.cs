using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1201_1250
{
    public class _1252_cells_with_odd_values_in_a_matrix
    {
        public int OddCells(int m, int n, int[][] indices)
        {
            int[,] mat= new int[m, n];
            int n1 = 0;
            foreach (var item in indices)
            {
                int r = item[0];
                int c = item[1];
                for (int i = 0; i < n; i++)
                {
                    mat[r, i]++;
                    if (mat[r, i] % 2 == 0)
                    {

                        if (n1 > 0)
                        {
                            n1--;
                        }
                    }
                    else
                    {
                        n1++;

                    }
                }
                for (int i = 0; i < m; i++)
                {
                    mat[i, c]++;
                    if (mat[i, c] % 2 == 0)
                    {

                        if (n1 > 0)
                        {
                            n1--;
                        }
                    }
                    else
                    {
                        n1++;

                    }
                }
            }
            return n1;
        }
    }
}
