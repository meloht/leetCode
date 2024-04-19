using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _832_FlippingAnImageAlg
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            int m = image.Length;
            int n = image[0].Length;
           
            for (int i = 0; i < m; i++)
            {
                Array.Reverse(image[i]);
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    image[i][j] = image[i][j] == 1 ? 0 : 1;
                }
            }
            return image;
        }
    }
}
