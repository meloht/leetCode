using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0994_RottingOrangesAlg
    {
        public int OrangesRotting(int[][] grid)
        {
            Queue<int[]> queue = new Queue<int[]>();
            int ans = 0;
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        AddQueue(grid, queue, i, j);
                    }
                    if (grid[i][j] == 1)
                    {
                        list.Add(new int[] { i, j });
                    }
                }
            }
            while (queue.Count > 0)
            {
                ans++;
                int count = queue.Count;
                List<int[]> ls = new List<int[]>();
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    grid[node[0]][node[1]] = 2;
                    ls.Add(node);
                  
                }
                foreach (var node in ls)
                {
                    AddQueue(grid, queue, node[0], node[1]);
                }
            }

            foreach (var node in list)
            {
                if (grid[node[0]][node[1]] == 1)
                {
                    return -1;
                }
            }

            return ans;
        }
        private void AddQueue(int[][] grid, Queue<int[]> queue, int i, int j)
        {
            if (i - 1 >= 0 && grid[i - 1][j] == 1)
            {
                queue.Enqueue(new int[] { i - 1, j });
            }
            if (j - 1 >= 0 && grid[i][j - 1] == 1)
            {
                queue.Enqueue(new int[] { i, j - 1 });
            }
            if (i + 1 < grid.Length && grid[i + 1][j] == 1)
            {
                queue.Enqueue(new int[] { i + 1, j });
            }
            if (j + 1 < grid[0].Length && grid[i][j + 1] == 1)
            {
                queue.Enqueue(new int[] { i, j + 1 });
            }

        }

       
    }
}
