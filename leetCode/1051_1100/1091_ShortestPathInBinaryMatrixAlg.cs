using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1091_ShortestPathInBinaryMatrixAlg
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            if (grid[0][0] == 1)
            {
                return -1;
            }
            int n = grid.Length;
            int[][] dist = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dist[i] = new int[n];
                Array.Fill(dist[i], int.MaxValue);
            }
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(0, 0));
            dist[0][0] = 1;
            while (queue.Count > 0)
            {
                Tuple<int, int> tuple = queue.Dequeue();
                int x = tuple.Item1, y = tuple.Item2;
                if (x == n - 1 && y == n - 1)
                {
                    return dist[x][y];
                }
                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        if (x + dx < 0 || x + dx >= n || y + dy < 0 || y + dy >= n)
                        { // 越界
                            continue;
                        }
                        if (grid[x + dx][y + dy] == 1 || dist[x + dx][y + dy] <= dist[x][y] + 1)
                        { // 单元格值不为 0 或已被访问
                            continue;
                        }
                        dist[x + dx][y + dy] = dist[x][y] + 1;
                        queue.Enqueue(new Tuple<int, int>(x + dx, y + dy));
                    }
                }
            }
            return -1;
        }


    }
}
