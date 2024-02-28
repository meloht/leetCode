using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1251_1300
{
    public class _1267_CountServersThatCommunicateAlg
    {

        public int CountServers(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            Dictionary<int, int> rows = new Dictionary<int, int>();
            Dictionary<int, int> cols = new Dictionary<int, int>();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        //行
                        if (!rows.ContainsKey(i))
                            rows.Add(i, 0);

                        rows[i]++;

                        //列
                        if (!cols.ContainsKey(j))
                            cols.Add(j, 0);

                        cols[j]++;
                    }
                }
            }

            int ans = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1 && (rows[i] > 1 || cols[j] > 1))
                    {
                        ans++;
                    }
                }
            }

            return ans;
        }

        private int cols;
        private int rows;
        public int CountServers1(int[][] grid)
        {
            rows = grid.Length;
            cols = grid[0].Length;
            int size = rows * cols;
            UnionFind union = new UnionFind(size);
            List<int> list = new List<int>();
            for (int i = 0; i < rows; i++)
            {
                List<int> listRow = new List<int>();
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 0)
                        continue;
                    int index = GetIndex(i, j);
                    list.Add(index);
                    listRow.Add(index);
                }
                for (int j = 1; j < listRow.Count; j++)
                {
                    int prev = listRow[j - 1];
                    int current = listRow[j];
                    union.Union(prev, current);
                }
            }

            for (int i = 0; i < cols; i++)
            {
                List<int> listCol = new List<int>();
                for (int j = 0; j < rows; j++)
                {
                    if (grid[j][i] == 0)
                        continue;
                    int index = GetIndex(j, i);

                    listCol.Add(index);
                }
                for (int j = 1; j < listCol.Count; j++)
                {
                    int prev = listCol[j - 1];
                    int current = listCol[j];
                    union.Union(prev, current);
                }
            }

            HashSet<int> set = new HashSet<int>();
            int ans = 0;
            foreach (var item in list)
            {
                int root = union.Find(item);
                int num = union.GetSize(root);
                if (num > 1 && set.Add(root))
                {
                    ans += union.GetSize(root);
                }
            }

            return ans;
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
