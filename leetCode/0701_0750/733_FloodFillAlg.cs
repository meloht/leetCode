using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _733_FloodFillAlg
    {
        int m = 0;
        int n = 0;
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            m = image.Length;
            n = image[0].Length;

            Dfs(image, sr, sc, image[sr][sc]);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (image[i][j] == -1)
                    {
                        image[i][j] = color;
                    }
                }
            }
            return image;
        }

        private void Dfs(int[][] image, int sr, int sc, int color)
        {
            if (sr >= m || sc >= n || sr < 0 || sc < 0)
                return;
            if (image[sr][sc] == -1)
                return;
            if (image[sr][sc] == color)
            {
                image[sr][sc] = -1;
            }
            else
            {
                return;
            }

            Dfs(image, sr + 1, sc, color);
            Dfs(image, sr - 1, sc, color);
            Dfs(image, sr, sc + 1, color);
            Dfs(image, sr, sc - 1, color);
        }
    }
}
