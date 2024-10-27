using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0501_0550
{
    public class _542_01MatrixAlg
    {
        int[][] dec = [[0, 1], [0, -1], [1, 0], [-1, 0]];
        public int[][] UpdateMatrix(int[][] mat)
        {

            int m = mat.Length, n = mat[0].Length;
            int[][] dist = new int[m][];
            for (int i = 0; i < m; i++)
            {
                dist[i] = new int[n];
            }
            bool[,] seen = new bool[m, n];
            Queue<int[]> queue = new Queue<int[]>();
            // 将所有的 0 添加进初始队列中
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (mat[i][j] == 0)
                    {
                        queue.Enqueue([i, j]);
                        seen[i, j] = true;
                    }
                }
            }

            // 广度优先搜索
            while (queue.Count > 0)
            {
                int[] cell = queue.Dequeue();
                int i = cell[0], j = cell[1];
                for (int d = 0; d < 4; ++d)
                {
                    int ni = i + dec[d][0];
                    int nj = j + dec[d][1];
                    if (ni >= 0 && ni < m && nj >= 0 && nj < n && !seen[ni, nj])
                    {
                        dist[ni][nj] = dist[i][j] + 1;
                        queue.Enqueue([ni, nj]);
                        seen[ni, nj] = true;
                    }
                }
            }

            return dist;


        }

    }
}
