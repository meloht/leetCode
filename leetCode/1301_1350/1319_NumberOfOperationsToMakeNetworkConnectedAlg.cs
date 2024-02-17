using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1301_1350
{
    public class _1319_NumberOfOperationsToMakeNetworkConnectedAlg
    {
        public int MakeConnected(int n, int[][] connections)
        {
            int num = connections.Length;

            if (num < n - 1)
            {
                return -1;
            }

            UnionFind unionFind = new UnionFind(n);
            foreach (var item in connections)
            {
                unionFind.Union(item[0], item[1]);
            }
            int count = unionFind.GetCount();
           

            return count - 1;
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
