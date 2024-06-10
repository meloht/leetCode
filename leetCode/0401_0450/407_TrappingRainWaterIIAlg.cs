using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0401_0450
{
    public class _407_TrappingRainWaterIIAlg
    {
        int[][] drs = [[1, 0], [-1, 0], [0, 1], [0, -1]];
        public int TrapRainWater1(int[][] heightMap)
        {
            if (heightMap.Length < 3 || heightMap[0].Length < 3)
                return 0;
            int m = heightMap.Length;
            int n = heightMap[0].Length;

            int ans = 0;
            int maxHeight = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    maxHeight = Math.Max(maxHeight, heightMap[i][j]);
                }
            }

            int[,] water = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    water[i, j] = maxHeight;
                }
            }

            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == m - 1 || j == n - 1)
                    {
                        if (water[i, j] > heightMap[i][j])
                        {
                            water[i, j] = heightMap[i][j];
                            queue.Enqueue([i, j]);
                        }
                    }
                }
            }

            while (queue.Count > 0)
            {
                int[] curr = queue.Dequeue();
                int x = curr[0];
                int y = curr[1];
                foreach (var item in drs)
                {
                    int row = x + item[0];
                    int col = y + item[1];
                    if (row > m - 1 || row < 0 || col < 0 || col > n - 1)
                    {
                        continue;
                    }

                    if (water[x, y] < water[row, col] && water[row, col] > heightMap[row][col])
                    {
                        water[row, col] = Math.Max(water[x, y], heightMap[row][col]);
                        queue.Enqueue([row, col]);
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ans += water[i, j] - heightMap[i][j];
                }
            }

            return ans;
        }


        public int TrapRainWater(int[][] heightMap)
        {
            if (heightMap.Length <= 2 || heightMap[0].Length <= 2)
            {
                return 0;
            }
            int m = heightMap.Length;
            int n = heightMap[0].Length;
            bool[,] visit = new bool[m, n];
            PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == 0 || i == m - 1 || j == 0 || j == n - 1)
                    {
                        pq.Enqueue([i * n + j, heightMap[i][j]], heightMap[i][j]);
                        visit[i, j] = true;
                    }
                }
            }
            int res = 0;
            int[] dirs = { -1, 0, 1, 0, -1 };
            while (pq.Count > 0)
            {
                int[] curr = pq.Dequeue();
                int x = curr[0] / n;
                int y = curr[0] % n;
                for (int k = 0; k < 4; ++k)
                {
                    int nx = x + dirs[k];
                    int ny = y + dirs[k + 1];
                    if (nx >= 0 && nx < m && ny >= 0 && ny < n && !visit[nx, ny])
                    {
                        if (curr[1] > heightMap[nx][ny])
                        {
                            res += curr[1] - heightMap[nx][ny];
                        }
                        int max = Math.Max(heightMap[nx][ny], curr[1]);
                        pq.Enqueue([nx * n + ny, max], max);
                        visit[nx, ny] = true;
                    }
                }
            }
            return res;


        }



    }
}
