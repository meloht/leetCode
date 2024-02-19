using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0959_RegionsCutBySlashesAlg
    {
        public int RegionsBySlashes(string[] grid)
        {
            int n = grid.Length;
            int size = 4 * n * n;
            UnionFind unionFind = new UnionFind(size);
            for (int i = 0; i < n; i++)
            {
                char[] row = grid[i].ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    int index = 4 * (i * n + j);
                    char ch = row[j];
                    if (ch == '/')
                    {
                        //合并 0、3，合并 1、2；
                        unionFind.Union(index, index + 3);
                        unionFind.Union(index + 1, index + 2);
                    }
                    else if (ch == '\\')
                    {
                        //合并 0、1，合并 2、3
                        unionFind.Union(index, index + 1);
                        unionFind.Union(index + 2, index + 3);
                    }
                    else
                    {
                        unionFind.Union(index, index + 1);
                        unionFind.Union(index + 1, index + 2);
                        unionFind.Union(index + 2, index + 3);
                    }

                    if (j + 1 < n)
                    {
                        unionFind.Union(index + 1, 4 * (i * n + j + 1) + 3);
                    }
                    if (i + 1 < n)
                    {
                        unionFind.Union(index + 2, 4 * ((i + 1) * n + j));
                    }
                }
            }
            return unionFind.Count;
        }


        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            private int count = 0;
            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];
                this.count = n;
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

        }
    }
}
