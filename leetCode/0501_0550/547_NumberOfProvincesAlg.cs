using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _547_NumberOfProvincesAlg
    {
        public int FindCircleNum(int[][] isConnected)
        {
            int n = isConnected.Length;
            UnionFind unionFind = new UnionFind(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (isConnected[i][j] == 1)
                    {
                        unionFind.Union(i, j);
                    }
                }
            }
            int ans = unionFind.GetCount();
            return ans;
        }


        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            private int size;
            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];
                this.size = n;
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
                size--;

            }
            public int GetCount()
            {
                return size;
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
