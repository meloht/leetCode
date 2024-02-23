using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _778_SwimInRisingWaterAlg
    {
        private static int[][] Directions = [[1, 0], [0, 1], [-1, 0], [0, -1]];
        private int n = 0;
        public int SwimInWater(int[][] grid)
        {
            n = grid.Length;
            int ans = 0;
            PriorityQueue<int[], int> priorityQueue = new PriorityQueue<int[], int>();

            bool[,] visited = new bool[n, n];
            UnionFind union = new UnionFind(n * n);
            priorityQueue.Enqueue([0, 0, 0, 0], grid[0][0]);
            while (priorityQueue.Count > 0)
            {
                var node = priorityQueue.Dequeue();
                int i = node[0];
                int j = node[1];
                int prei = node[2];
                int prej = node[3];
                union.Union(grid[i][j], grid[prei][prej]);
                visited[i, j] = true;

                ans = Math.Max(ans, grid[i][j]);

                foreach (int[] item in Directions)
                {
                    int newRow = item[0] + i;
                    int newCol = item[1] + j;
                    if (IsInRange(newRow, newCol) && !visited[newRow, newCol])
                    {
                        priorityQueue.Enqueue([newRow, newCol, i, j], grid[newRow][newCol]);
                    }
                }
                if (union.IsConnect(grid[n - 1][n - 1], grid[0][0]))
                {
                    return ans;
                }
            }

            return ans;
        }

        private bool IsInRange(int x, int y)
        {
            return x >= 0 && x < n && y >= 0 && y < n;
        }


        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            private int[] size;
            private int count = 0;
            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];
                this.size = new int[n];
                this.count = n;
                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
                    this.size[i] = 1;
                }
            }

            public void Union(int x, int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);
                if (rootX == rootY)
                {
                    return;
                }
                int xRank = this.ranks[rootX];
                int yRank = this.ranks[rootY];
                if (xRank < yRank)
                {
                    this.parent[rootX] = rootY;
                    this.size[rootY] += size[rootX];
                }
                else if (xRank > yRank)
                {
                    this.parent[rootY] = rootX;
                    this.size[rootX] += size[rootY];
                }
                else
                {
                    parent[rootX] = rootY;
                    this.ranks[rootY]++;
                    this.size[rootY] += size[rootX];
                }
                this.count--;

            }
            /// <summary>
            /// 路径压缩
            /// </summary>
            /// <returns></returns>
            public int Find(int x)
            {
                if (x != parent[x])
                {
                    parent[x] = Find(parent[x]);
                }
                return parent[x];
            }
            public int Count
            {
                get { return count; }
            }
            public int GetSize(int x)
            {
                int root = Find(x);
                return size[root];
            }

            public bool IsConnect(int x, int y)
            {
                int rootx = Find(x);
                int rooty = Find(y);
                if (rootx == rooty)
                    return true;
                return false;
            }
        }
    }
}
