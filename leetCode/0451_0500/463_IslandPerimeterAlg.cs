using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _463_IslandPerimeterAlg
    {
        private static int[][] Directions = [[0, 1], [1, 0], [-1, 0], [0, -1]];
        int ans = 0;
        private int cols;
        private int rows;
        public int IslandPerimeter(int[][] grid)
        {
            cols = grid[0].Length;
            rows = grid.Length;
            bool[,] visited = new bool[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        Dfs(grid, i, j, visited);
                        return ans;
                    }
                }
            }
            return ans;
        }

        private void Dfs(int[][] grid, int i, int j, bool[,] visited)
        {
            if (IsInRange(i, j) == false)
            {
                return;
            }
            if (grid[i][j] == 0)
                return;

            if (visited[i, j])
                return;

            visited[i, j] = true;

            foreach (int[] item in Directions)
            {
                int newi = i + item[0];
                int newj = j + item[1];
                if (IsInRange(newi, newj) == false)
                {
                    ans++;
                    continue;
                }
                if (grid[newi][newj] == 0)
                {
                    ans++;
                }

            }
            foreach (int[] item in Directions)
            {
                int newi = i + item[0];
                int newj = j + item[1];

                Dfs(grid, newi, newj, visited);
            }
        }

        private bool IsInRange(int x, int y)
        {
            return x >= 0 && x < rows && y >= 0 && y < cols;
        }
    }
}
