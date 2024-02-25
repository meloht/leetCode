using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _785_IsGraphBipartiteAlg
    {
        public bool IsBipartite(int[][] graph)
        {
            int n = graph.Length;
            UnionFind union = new UnionFind(n);
            foreach (var item in graph)
            {
                for (int i = 1; i < item.Length; i++)
                {
                    union.Union(item[i - 1], item[i]);
                }

            }
          
            for (int i = 0; i < n; i++)
            {
                int[] edge = graph[i];
                foreach (var item in edge)
                {
                    if (union.IsConnect(i, item))
                        return false;
                }
            }

            return true;
        }


        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            private int count;
            private int[] size;

            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];
                this.count = n;
                this.size = new int[n];
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
            public int GetSize(int x)
            {
                int root = Find(x);
                return size[root];
            }
            public int Count
            {
                get { return this.count; }
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
