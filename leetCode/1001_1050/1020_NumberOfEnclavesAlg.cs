using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1020_NumberOfEnclavesAlg
    {
        private int cols;
        private int rows;
        private static int[][] Directions = [[0, 1], [1, 0], [-1, 0], [0, -1]];
        public int NumEnclaves(int[][] grid)
        {
            rows = grid.Length;
            cols = grid[0].Length;
            UnionFind union = new UnionFind(rows * cols);
            int ans = 0;
            List<int> borderlist = new List<int>();
            List<int> list = new List<int>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 0)
                        continue;

                    int index = GetIndex(i, j);
                    if (i == 0 || j == 0 || i == rows - 1 || j == cols - 1)
                    {
                        borderlist.Add(index);
                    }
                    else
                    {
                        list.Add(index);
                    }

                    for (int k = 0; k < 2; k++)
                    {
                        int[] item = Directions[k];
                        int nx = item[0] + i;
                        int ny = item[1] + j;
                        if (IsInRange(nx, ny) && grid[nx][ny] == 1)
                        {
                            union.Union(GetIndex(nx, ny), index);
                        }
                    }
                }
            }
            HashSet<int> set = new HashSet<int>();
           
            foreach (var item in borderlist)
            {
                int root = union.Find(item);
                set.Add(root);

            }
            HashSet<int> set2 = new HashSet<int>();
            foreach (var item in list)
            {
                int root = union.Find(item);
                if (set.Contains(root))
                    continue;
                if (set2.Add(root))
                {
                    int num = union.GetSize(item);
                    ans += num;
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
