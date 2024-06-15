using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _417_PacificAtlanticWaterFlowAlg
    {
        int[][] dirs = [[1, 0], [-1, 0], [0, 1], [0, -1]];
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            List<int[]> res=new List<int[]>();
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = 0; j < heights[0].Length; j++)
                {
                    bool[,] visited1 = new bool[heights.Length, heights[0].Length];
                    bool[,] visited2 = new bool[heights.Length, heights[0].Length];

                    if (Dfs1(heights, i, j, visited1, heights[i][j]) && Dfs2(heights, i, j, visited2, heights[i][j]))
                    {
                        res.Add([i, j]);
                    }
                }
            }
            return res.ToArray();
        }

        private bool Dfs1(int[][] heights, int row, int col, bool[,] visited,int val)
        {
           

            if (row < 0 || col < 0 || row > heights.Length - 1 || col > heights[0].Length - 1)
                return false;

            if (visited[row, col])
                return false;

            if (heights[row][col] > val)
                return false;

            if (row == 0 || col == 0)
                return true;

            visited[row, col] = true;


            foreach (var item in dirs)
            {
                int nr = item[0] + row;
                int nc = item[1] + col;

                if (Dfs1(heights, nr, nc, visited, heights[row][col]))
                    return true;

            }

            return false;
        }
        private bool Dfs2(int[][] heights, int row, int col, bool[,] visited, int val)
        {
           

            if (row < 0 || col < 0 || row > heights.Length - 1 || col > heights[0].Length - 1)
                return false;

            if (visited[row, col])
                return false;

            if (heights[row][col] > val)
                return false;

            if (row == heights.Length - 1 || col == heights[0].Length - 1)
                return true;

            visited[row, col] = true;


            foreach (var item in dirs)
            {
                int nr = item[0] + row;
                int nc = item[1] + col;

                if (Dfs2(heights, nr, nc, visited, heights[row][col]))
                    return true;

            }

            return false;
        }

        int m, n;

        int[][] heights;

        public IList<IList<int>> PacificAtlantic1(int[][] heights)
        {
            this.heights = heights;
            this.m = heights.Length;
            this.n = heights[0].Length;
            bool[][] pacific = new bool[m][];
            bool[][] atlantic = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                pacific[i] = new bool[n];
                atlantic[i] = new bool[n];
            }
            for (int i = 0; i < m; i++)
            {
                DFS(i, 0, pacific);
            }
            for (int j = 1; j < n; j++)
            {
                DFS(0, j, pacific);
            }
            for (int i = 0; i < m; i++)
            {
                DFS(i, n - 1, atlantic);
            }
            for (int j = 0; j < n - 1; j++)
            {
                DFS(m - 1, j, atlantic);
            }
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (pacific[i][j] && atlantic[i][j])
                    {
                        IList<int> cell = new List<int>();
                        cell.Add(i);
                        cell.Add(j);
                        result.Add(cell);
                    }
                }
            }
            return result;
        }

        public void DFS(int row, int col, bool[][] ocean)
        {
            if (ocean[row][col])
            {
                return;
            }
            ocean[row][col] = true;
            foreach (int[] dir in dirs)
            {
                int newRow = row + dir[0], newCol = col + dir[1];
                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && heights[newRow][newCol] >= heights[row][col])
                {
                    DFS(newRow, newCol, ocean);
                }
            }
        }


    }
}
