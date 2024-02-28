﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1251_1300
{
    public class _1254_NumberOfClosedIslandsAlg
    {
        private int cols;
        private int rows;
        private static int[][] Directions = [[0, 1], [1, 0], [-1, 0], [0, -1]];
        public int ClosedIsland(int[][] grid)
        {
            rows = grid.Length;
            cols = grid[0].Length;
            int size = rows * cols + 1;
            int n = size - 1;
            UnionFind union = new UnionFind(size);
            List<int> list = new List<int>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                        continue;
                    int index = GetIndex(i, j);
                    if (i == 0 || j == 0 || i == rows - 1 || j == cols - 1)
                    {
                        union.Union(index, n);
                    }
                    else
                    {
                        list.Add(index);
                    }

                    for (int k = 0; k < 2; k++)
                    {
                        int[] item = Directions[k];
                        int nx = i + item[0];
                        int ny = j + item[1];
                        if (IsInRange(nx, ny) && grid[nx][ny] == 0)
                        {
                            union.Union(index, GetIndex(nx, ny));
                        }
                    }
                }
            }

            int border = union.Find(n);
            HashSet<int> set2 = new HashSet<int>();
            foreach (var item in list)
            {
                int root = union.Find(item);
                if (border != root)
                {
                    set2.Add(root);
                }
            }

            return set2.Count;
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
