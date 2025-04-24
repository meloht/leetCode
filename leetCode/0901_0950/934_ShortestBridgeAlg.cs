using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _934_ShortestBridgeAlg
    {
        int[][] dir = [[0, 1], [0, -1], [1, 0], [-1, 0]];
        public int ShortestBridge(int[][] grid)
        {
            int n = grid.Length;
            bool[,] visited = new bool[n, n];
            List<int[]> list = GetList(grid, visited);
          
            int ans = 0;
            Queue<int[]> queue = new Queue<int[]>();
            foreach (var item in list)
            {
                if (item[2] == 1)
                {
                    queue.Enqueue(item);
                }
            }

            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    int[] nn = queue.Dequeue();
                    int row = nn[0];
                    int col = nn[1];
                    foreach (var item in dir)
                    {
                        int x = row + item[0];
                        int y = col + item[1];
                        if (x < 0 || x >= n || y < 0 || y >= n)
                            continue;
                        if (visited[x, y])
                            continue;

                        if (grid[x][y] == 1)
                            return ans;
                        if (grid[x][y] == 0)
                        {
                            queue.Enqueue([x, y]);
                            visited[x, y] = true;
                        }
                    }
                }

                ans++;
            }

            return ans;
        }

        private List<int[]> GetList(int[][] grid, bool[,] visited)
        {
            int n = grid.Length;
            int[] arr = GetBoder(grid);
            List<int[]> list = new List<int[]>();
            Dfs(list, n, arr[0], arr[1], visited, grid);
            return list;
        }

        private int[] GetBoder(int[][] grid)
        {
            int n = grid.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        foreach (var item in dir)
                        {
                            int x = i + item[0];
                            int y = j + item[1];
                            if (x >= 0 && x < n && y >= 0 && y < n && grid[x][y] == 0)
                            {
                                return [i, j];
                            }
                        }
                    }
                }
            }
            return [];
        }


        private void Dfs(List<int[]> list, int n, int x, int y, bool[,] visited, int[][] grid)
        {
            if (x < 0 || x >= n || y < 0 || y >= n)
                return;
            if (grid[x][y] == 0)
                return;
            if (visited[x, y])
                return;
            visited[x, y] = true;
            int[] p = [x, y, 0];
            list.Add(p);
            foreach (var item in dir)
            {
                int xx = x + item[0];
                int yy = y + item[1];
                if (xx >= 0 && xx < n && yy >= 0 && yy < n && grid[xx][yy] == 0)
                {
                    p[2] = 1;
                }
                Dfs(list, n, xx, yy, visited, grid);
            }
        }
    }
}
