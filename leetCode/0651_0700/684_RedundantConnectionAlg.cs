using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _684_RedundantConnectionAlg
    {
        public int[] FindRedundantConnection1(int[][] edges)
        {

            int[] res = new int[2];
            for (int i = edges.Length - 1; i >= 0; i--)
            {
                UnionFind unionFind = new UnionFind(edges.Length + 1);
                for (int j = 0; j < edges.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    unionFind.Union(edges[j][0], edges[j][1]);

                }

                if (unionFind.GetCount() == 1)
                {
                    return edges[i];
                }

            }

            return res;
        }

        public int[] FindRedundantConnection(int[][] edges)
        {

            int[] res = new int[2];
            UnionFind unionFind = new UnionFind(edges.Length + 1);
            for (int i = 0; i < edges.Length; i++)
            {
                int[] node = edges[i];
                if (unionFind.Find(node[0]) != unionFind.Find(node[1]))
                {
                    unionFind.Union(node[0], node[1]);
                }
                else
                {
                    return node;
                }
            }

            return res;
        }

        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            private int count;

            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];
                this.count = n - 1;
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
            public int GetCount()
            {
                return this.count;
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
