using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _498_DiagonalTraverseAlg
    {
        public int[] FindDiagonalOrder(int[][] mat)
        {
            int[] nums = new int[mat.Length * mat[0].Length];

            int n = 0;
            int m = 0;
            bool flag = true;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = mat[n][m];
                if (flag)
                {
                    if (n == 0 && m < mat[0].Length - 1)
                    {
                        flag = false;
                        m++;

                    }
                    else if (m == mat[0].Length - 1 && n >= 0)
                    {
                        flag = false;
                        n++;
                    }
                    else
                    {
                        n--;
                        m++;
                    }

                }
                else
                {

                    if (n == mat.Length - 1 && m >= 0)
                    {
                        flag = true;
                        m++;
                    }
                    else if (n < mat.Length - 1 && m == 0)
                    {
                        flag = true;
                        n++;
                    }
                    else
                    {
                        n++;
                        m--;
                    }

                }

            }


            return nums;
        }
    }
}
