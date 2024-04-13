using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _661_ImageSmootherAlg
    {
        public int[][] ImageSmoother(int[][] img)
        {
            int m = img.Length;
            int n = img[0].Length;
            int[][] img2 = new int[m][];
            for (int i = 0; i < m; i++)
            {
                img2[i] = new int[n];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    img2[i][j] = Avg(img, i, j, m, n);
                }
            }
            return img2;
        }
        private int Avg(int[][] img, int k, int h, int m, int n)
        {
            int mm2 = k + 1 >= m ? m : k + 2;
            int nn2 = h + 1 >= n ? n : h + 2;
            int sum = 0;
            int count = 0;
            int mm1 = k - 1 < 0 ? 0 : k - 1;
            int nn1 = h - 1 < 0 ? 0 : h - 1;

            for (int i = mm1; i < mm2; i++)
            {
                for (int j = nn1; j < nn2; j++)
                {
                    sum += img[i][j];
                    count++;
                }
            }
            int avg = sum / count;

            return avg;
        }
    }
}
