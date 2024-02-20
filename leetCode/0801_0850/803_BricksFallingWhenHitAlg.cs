using System;
using System.Collections.Generic;
using System.Linq;
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

            for (int i = 0; i < hits.Length; i++)
            {
                int[] p = hits[i];
                int num = grid[p[0]][p[1]];
                grid[p[0]][p[1]] = 0;
                if (num == 0)
                {
                    continue;
                }
                UnionFind union = new UnionFind(size);

                List<int[]> points = new List<int[]>();
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (grid[j][k] == 1)
                        {

                            points.Add(new int[] { j, k });
                            int index = n * j + k;
                            if (j > 0 && grid[j - 1][k] == 1)
                            {
                                union.Union(index, (j - 1) * n + k);
                            }
                            if (k > 0 && grid[j][k - 1] == 1)
                            {
                                union.Union(index, j * n + k - 1);
                            }
                            if (j < m - 1 && grid[j + 1][k] == 1)
                            {
                                union.Union(index, (j + 1) * n + k);
                            }
                            if (k < n - 1 && grid[j][k + 1] == 1)
                            {
                                union.Union(index, j * n + k + 1);
                            }
                        }

                    }
                }

                int count = 0;
                foreach (int[] item in points)
                {
                    int index = n * item[0] + item[1];
                    var d = union.Find(index);
                    if (d >= m)
                    {
                        count++;
                    }
                }
                res[i] = count;
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
        }
    }
}
