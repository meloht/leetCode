using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _803_BricksFallingWhenHitAlg
    {
        public int[] HitBricks(int[][] grid, int[][] hits)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int size = n * m;
            int[] res = new int[hits.Length];
            UnionFind union = new UnionFind(size);

            HashSet<int> hitMap = new HashSet<int>();

            foreach (int[] item in hits)
            {
                int i = item[0];
                int j = item[1];
                int index = n * i + j;
                hitMap.Add(index);
            }
            List<int> points = new List<int>();
            HashSet<int> heads = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        continue;
                    }

                    int index = n * i + j;
                    if (hitMap.Contains(index))
                    {
                        continue;
                    }
                    if (i == 0)
                    {
                        heads.Add(index);
                    }
                    else
                    {
                        points.Add(index);
                    }

                    int next1 = (i + 1) * n + j;
                    if (i < m - 1 && grid[i + 1][j] == 1 && !hitMap.Contains(next1))
                    {

                        union.Union(index, next1);
                    }
                    int next2 = i * n + j + 1;
                    if (j < n - 1 && grid[i][j + 1] == 1 && !hitMap.Contains(next2))
                    {
                        union.Union(index, next2);
                    }
                }
            }

            for (int k = hits.Length - 1; k >= 0; k--)
            {
                var item = hits[k];

                HashSet<int> visited = new HashSet<int>();
                foreach (var pp in heads)
                {
                    var d = union.Find(pp);
                    visited.Add(d);
                }
                int count = 0;
                foreach (var item1 in points)
                {
                    int root = union.Find(item1);
                    if (!visited.Contains(root))
                    {
                        count++;
                    }
                }

                res[k] = count;

                int i = item[0];
                int j = item[1];
                if (grid[i][j] == 0)
                {
                    continue;
                }
                int index = n * i + j;
                if (index < n)
                {
                    heads.Add(index);
                }
                else
                {
                    points.Add(index);
                }
                hitMap.Remove(index);

                int next1 = (i + 1) * n + j;
                if (i < m - 1 && grid[i + 1][j] == 1 && !hitMap.Contains(next1))
                {

                    union.Union(index, next1);
                }
                int next2 = i * n + j + 1;
                if (j < n - 1 && grid[i][j + 1] == 1 && !hitMap.Contains(next2))
                {
                    union.Union(index, next2);
                }
                int next3 = (i - 1) * n + j;
                if (i > 0 && grid[i - 1][j] == 1 && !hitMap.Contains(next3))
                {

                    union.Union(index, next3);
                }
                int next4 = i * n + j - 1;
                if (j > 0 && grid[i][j - 1] == 1 && !hitMap.Contains(next4))
                {
                    union.Union(index, next4);
                }
            }


            return res;
        }


        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];

                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
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
                }
                else if (xRank > yRank)
                {
                    this.parent[rootY] = rootX;
                }
                else
                {
                    parent[rootX] = rootY;
                    this.ranks[rootY]++;
                }

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
