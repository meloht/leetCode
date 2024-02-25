using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _827_MakingALargeIslandAlg
    {
        private int cols;
        private int rows;
        private static int[][] Directions = [[0, 1], [1, 0], [-1, 0], [0, -1]];
        public int LargestIsland(int[][] grid)
        {
            rows = grid.Length;
            cols = grid[0].Length;
            int size = rows * cols;
            UnionFind union = new UnionFind(size);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        if (grid[i][j] == 0)
                            continue;
                        var item = Directions[k];
                        int nx = item[0] + i;
                        int ny = item[1] + j;
                        if (IsInRange(nx, ny) && grid[nx][ny] == 1)
                        {
                            union.Union(GetIndex(nx, ny), GetIndex(i, j));
                        }
                    }

                }
            }
            int ans = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        int index = GetIndex(i, j);
                        int count = union.GetSize(index);
                        ans = Math.Max(count, ans);
                    }
                    else
                    {
                        int num = 1;
                        HashSet<int> set = new HashSet<int>();
                        foreach (int[] item in Directions)
                        {
                            int nx = item[0] + i;
                            int ny = item[1] + j;
                            if (IsInRange(nx, ny) && grid[nx][ny] == 1)
                            {
                                int index = GetIndex(nx, ny);
                                int root = union.Find(index);
                                if (set.Contains(root))
                                    continue;

                                num += union.GetSize(root);
                                set.Add(root);
                            }

                        }
                        ans = Math.Max(num, ans);

                    }
                }
            }

            return ans;
        }
        private bool IsInRange(int x, int y)
        {
            return x >= 0 && x < rows && y >= 0 && y < cols;
        }

        private int GetIndex(int x, int y)
        {
            return x * cols + y;
        }

        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            private int count;
            private int[] size;

            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];
                this.count = n;
                this.size = new int[n];
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
            public int GetSize(int x)
            {
                int root = Find(x);
                return size[root];
            }
            public int Count
            {
                get { return this.count; }
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
