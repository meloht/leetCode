﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _886_PossibleBipartitionAlg
    {
        public bool PossibleBipartition(int n, int[][] dislikes)
        {
            UnionFind union = new UnionFind(n + 1);
            Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();

            foreach (var item in dislikes)
            {
                if (dict.ContainsKey(item[0]))
                {
                    dict[item[0]].Add(item[1]);
                }
                else
                {
                    HashSet<int> set = new HashSet<int>();
                    set.Add(item[1]);
                    dict.Add(item[0], set);
                }

            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (dict.ContainsKey(i) && dict[i].Contains(j))
                    {
                        continue;
                    }
                    union.Union(i, j);
                }
            }

            foreach (var item in dislikes)
            {
                if (union.IsConnect(item[0], item[1]))
                {
                    return false;
                }
            }
            return true;
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
