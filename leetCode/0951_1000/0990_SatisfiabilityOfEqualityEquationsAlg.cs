﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0990_SatisfiabilityOfEqualityEquationsAlg
    {
        public bool EquationsPossible(string[] equations)
        {
            UnionFind unionFind = new UnionFind(26);

            foreach (var item in equations)
            {
                if (item[1] == '=')
                {
                    int index1 = item[0] - 'a';
                    int index2 = item[3] - 'a';
                    unionFind.Union(index1, index2);

                }
            }

            foreach (var item in equations)
            {
                if (item[1] == '!')
                {
                    int index1 = item[0] - 'a';
                    int index2 = item[3] - 'a';
                    if (unionFind.Find(index1) == unionFind.Find(index2))
                    {
                        return false;
                    }

                }
            }
            return true;
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
