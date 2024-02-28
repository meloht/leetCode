using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1061_LexicographicallySmallestEquivalentStringAlg
    {
        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            UnionFind union = new UnionFind(26);
            for (int i = 0; i < s1.Length; i++)
            {
                int ch1 = s1[i] - 'a';
                int ch2 = s2[i] - 'a';
                union.Union(ch1, ch2);
            }
            char[] dict = new char[26];
            Array.Fill(dict, '0');

            for (int i = 0; i < s1.Length; i++)
            {
                int root = union.Find(s1[i] - 'a');

                if (dict[root] == '0')
                {
                    dict[root] = MinChar(s1[i], s2[i]);
                }
                else
                {
                    dict[root] = MinChar(s1[i], dict[root]);
                    dict[root] = MinChar(s2[i], dict[root]);
                }
               
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in baseStr)
            {
                int ch = item - 'a';
                int root = union.Find(ch);
                if (dict[root] != '0')
                {
                    sb.Append(dict[root]);
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
        private char MinChar(char ch1, char ch2)
        {
            if (ch1 > ch2)
            {
                return ch2;
            }
            return ch1;
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
