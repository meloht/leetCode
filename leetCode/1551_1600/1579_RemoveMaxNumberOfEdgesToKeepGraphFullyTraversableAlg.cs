using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1551_1600
{
    public class _1579_RemoveMaxNumberOfEdgesToKeepGraphFullyTraversableAlg
    {
        public int MaxNumEdgesToRemove(int n, int[][] edges)
        {
            List<int[]> edges1 = new List<int[]>();
            List<int[]> edges2 = new List<int[]>();

            UnionFind union1 = new UnionFind(n + 1);
            UnionFind union2 = new UnionFind(n + 1);

            int baseNum = 0;

            foreach (var item in edges)
            {
                if (item[0] == 1)
                {
                    edges1.Add(item);
                }
                else if (item[0] == 2)
                {
                    edges2.Add(item);
                }
                else if (item[0] == 3)
                {
                    int origin = union1.Count;
                    union1.Union(item[1], item[2]);
                    union2.Union(item[1], item[2]);
                    if (union1.Count == origin)
                    {
                        baseNum++;
                    }
                }
            }
            int count1 = GetCount(edges1, union1);
            int count2 = GetCount(edges2, union2);

            if (union1.Count > 2)
            {
                return -1;
            }
            if (union2.Count > 2)
            {
                return -1;
            }


            return baseNum + count1 + count2;
        }
        private int GetCount(List<int[]> edges, UnionFind union)
        {
            int count = 0;
            foreach (var item in edges)
            {
                int origin = union.Count;
                union.Union(item[1], item[2]);
                if (union.Count == origin)
                {
                    count++;
                }
            }
            return count;
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
