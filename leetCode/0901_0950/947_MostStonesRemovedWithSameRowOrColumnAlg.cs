using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _947_MostStonesRemovedWithSameRowOrColumnAlg
    {
        public int RemoveStones1(int[][] stones)
        {
            int n = stones.Length;
            UnionFind unionFind = new UnionFind(n);
            for (int i = 0; i < n; i++)
            {
                var a = stones[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (i == j)
                        continue;
                    var b = stones[j];
                    if (a[0] != b[0] && a[1] == b[1])
                    {
                        unionFind.Union(i, j);
                    }
                    else if (a[1] != b[1] && a[0] == b[0])
                    {
                        unionFind.Union(i, j);
                    }
                }
            }
            int ans = n - unionFind.Count;

            return ans;
        }

        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            private int count = 0;
            public UnionFind(int n)
            {
                this.count = n;
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


        public int RemoveStones(int[][] stones)
        {
            UnionMap unionMap = new UnionMap();
            foreach (var item in stones)
            {
                unionMap.Union(item[0] + 10001, item[1]);
            }

            return stones.Length - unionMap.Count;
        }

        private class UnionMap
        {
            private Dictionary<int, int> parent = new Dictionary<int, int>();
            private int count = 0;

            public int Count
            {
                get { return count; }
            }

            public int Find(int x)
            {
                if (!parent.ContainsKey(x))
                {
                    parent.Add(x, x);
                    // 并查集集中新加入一个结点，结点的父亲结点是它自己，所以连通分量的总数 +1
                    count++;
                }
                if (x != parent[x])
                {
                    parent[x] = Find(parent[x]);
                }

                return parent[x];
            }

            public void Union(int x, int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);
                if (rootX == rootY)
                    return;

                parent[rootX] = rootY;
                // 两个连通分量合并成为一个，连通分量的总数 -1
                count--;

            }
        }
    }
}
