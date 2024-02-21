using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _803_BricksFallingWhenHitAlg
    {
        private int cols;
        private int rows;
        private static int[][] Directions = [[0, 1], [1, 0], [-1, 0], [0, -1]];
        public int[] HitBricks(int[][] grid, int[][] hits)
        {
            this.rows = grid.Length;
            this.cols = grid[0].Length;

            int[,] copy = new int[rows, cols];

            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    copy[i, j] = grid[i][j];
                }
            }
            foreach (int[] item in hits)
            {
                copy[item[0], item[1]] = 0;
            }

            int size = rows * cols;

            UnionFind union = new UnionFind(size + 1);
            for (int i = 0; i < this.cols; i++)
            {
                if (copy[0, i] == 1)
                {
                    union.Union(i, size);
                }
            }

            for (int i = 1; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    if (copy[i, j] == 0)
                    {
                        continue;
                    }
                    if (copy[i - 1, j] == 1)
                    {
                        union.Union(GetIndex(i - 1, j), GetIndex(i, j));
                    }
                    if (j > 0 && copy[i, j - 1] == 1)
                    {
                        union.Union(GetIndex(i, j - 1), GetIndex(i, j));
                    }
                }
            }

            int[] res = new int[hits.Length];

            for (int i = hits.Length - 1; i >= 0; i--)
            {
                int x = hits[i][0];
                int y = hits[i][1];
                if (grid[x][y] == 0)
                    continue;

                int origin = union.GetSize(size);
                if (x == 0)
                {
                    union.Union(y, size);
                }
                foreach (int[] item in Directions)
                {
                    int nx = item[0] + x;
                    int ny = item[1] + y;
                    if (IsInRange(nx, ny) && copy[nx, ny] == 1)
                    {
                        union.Union(GetIndex(nx, ny), GetIndex(x, y));
                    }
                }

                int current = union.GetSize(size);

                res[i] = Math.Max(0, current - origin - 1);
                copy[x, y] = 1;
            }

            return res;
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
