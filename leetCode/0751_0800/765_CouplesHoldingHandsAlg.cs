using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _765_CouplesHoldingHandsAlg
    {
        public int MinSwapsCouples1(int[] row)
        {
            int ans = 0;
            for (int i = 0; i < row.Length; i += 2)
            {
                int x = row[i];
                int y = x ^ 1;
                if (row[i + 1] == y)
                {
                    continue;
                }
                for (int j = 0; j < row.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (row[j] == y)
                    {
                        int temp = row[i + 1];
                        row[i + 1] = row[j];
                        row[j] = temp;
                        ans++;
                        break;
                    }
                }
            }
            return ans;
        }

        public int MinSwapsCouples(int[] row)
        {
            int n = row.Length / 2;
            UnionFind union = new UnionFind(n);

            for (int i = 0; i < row.Length; i += 2)
            {
                var p1 = row[i];
                var p2 = row[i + 1];
                int p11 = p1 >> 1;
                int p22 = p2 >> 1;
                if (p11 != p22)
                {
                    union.Union(p11, p22);
                }
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (union.Find(i) == i)
                {
                    ans++;
                }
            }

            return n - ans;
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
