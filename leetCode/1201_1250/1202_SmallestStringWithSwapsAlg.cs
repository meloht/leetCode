using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1201_1250
{
    public class _1202_SmallestStringWithSwapsAlg
    {
        public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
        {
            int n = s.Length;
            UnionFind unionFind = new UnionFind(n);

            foreach (var item in pairs)
            {
                unionFind.Union(item[0], item[1]);
            }

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                int root = unionFind.Find(i);
                if (!dict.ContainsKey(root))
                {
                    dict.Add(root, new List<int>());
                }
                dict[root].Add(i);
            }
            char[] newChar = new char[n];
            foreach (var item in dict.Values)
            {
                List<char> ls = new List<char>();
                foreach (int index in item)
                {
                    ls.Add(s[index]);
                }
                ls.Sort();
                for (int i = 0; i < item.Count; i++)
                {
                    newChar[item[i]] = ls[i];
                }
            }

            return new string(newChar);
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
    }
}
