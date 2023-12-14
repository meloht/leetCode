using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _73_SetMatrixZeroesAlg
    {
        public void SetZeroes(int[][] matrix)
        {
            HashSet<int> iSet = new HashSet<int>();
            HashSet<int> jSet = new HashSet<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (!iSet.Contains(i))
                        {
                            iSet.Add(i);
                        }
                        if (!jSet.Contains(j))
                        {
                            jSet.Add(j);
                        }
                    }
                }
            }
            foreach (int i in iSet)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = 0;
                }
            }
            foreach (int j in jSet)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}
