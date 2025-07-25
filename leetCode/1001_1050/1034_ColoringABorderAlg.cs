using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1034_ColoringABorderAlg
    {
        public int[][] ColorBorder(int[][] grid, int row, int col, int color)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            bool[,] used = new bool[m, n];
            int val = grid[row][col];

            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue([row, col]);
            used[row, col] = true;
            int[][] dir = [[0, 1], [1, 0], [-1, 0], [0, -1]];
            List<int[]> list = new List<int[]>();
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var item = queue.Dequeue();
                    int r = item[0];
                    int c = item[1];

                    foreach (var ds in dir)
                    {
                        int x = r + ds[0];
                        int y = c + ds[1];
                        if (x >= 0 && x < m && y >= 0 && y < n && !used[x, y])
                        {
                            if (grid[x][y] != val)
                            {
                                list.Add([r, c]);
                            }
                            else
                            {
                                used[x, y] = true;
                                queue.Enqueue([x, y]);
                            }
                        }

                    }
                    if (r == 0 || r == m - 1 || c == 0 || c == n - 1)
                    {
                        list.Add([r, c]);
                    }
                }
            }

            foreach (var item in list)
            {
                grid[item[0]][item[1]] = color;
            }
           


            return grid;
        }
    }
}
