using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1391_CheckIfThereIsAValidPathInAGridAlg
    {
        private int cols;
        private int rows;

        public bool HasValidPath(int[][] grid)
        {
            rows = grid.Length;
            cols = grid[0].Length;
            int size = rows * cols;
            UnionFind union = new UnionFind(size);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int index = GetIndex(i, j);
                    int nx = i + 1;
                    int ny = j;
                    if (IsInRange(nx, ny))
                    {
                        if (grid[i][j] == 2 && (grid[nx][ny] == 5 || grid[nx][ny] == 6 || grid[nx][ny] == 2))
                        {
                            union.Union(index, GetIndex(nx, ny));
                        }
                        else if (grid[i][j] == 3 && (grid[nx][ny] == 2 || grid[nx][ny] == 5 || grid[nx][ny] == 6))
                        {
                            union.Union(index, GetIndex(nx, ny));
                        }
                        else if (grid[i][j] == 4 && (grid[nx][ny] == 2 || grid[nx][ny] == 5 || grid[nx][ny] == 6))
                        {
                            union.Union(index, GetIndex(nx, ny));
                        }
                    }
                    nx = i;
                    ny = j + 1;

                    if (IsInRange(nx, ny))
                    {
                        if (grid[i][j] == 1 && (grid[nx][ny] == 3 || grid[nx][ny] == 5 || grid[nx][ny] == 1))
                        {
                            union.Union(index, GetIndex(nx, ny));
                        }
                        else if (grid[i][j] == 4 && (grid[nx][ny] == 1 || grid[nx][ny] == 3 || grid[nx][ny] == 5))
                        {
                            union.Union(index, GetIndex(nx, ny));
                        }
                        else if (grid[i][j] == 6 && (grid[nx][ny] == 1 || grid[nx][ny] == 3 || grid[nx][ny] == 5))
                        {
                            union.Union(index, GetIndex(nx, ny));
                        }
                    }
                }
            }

            bool bl = union.IsConnect(0, GetIndex(rows - 1, cols - 1));

            return bl;
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
