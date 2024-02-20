using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _721_AccountsMergeAlg
    {
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int n = accounts.Count;
            UnionFind union = new UnionFind(n);
            for (int i = 0; i < n; i++)
            {
                var item = accounts[i];
                for (int j = 1; j < item.Count; j++)
                {
                    string mail = item[j];
                    if (dict.ContainsKey(mail) )
                    {
                        if (dict[mail] != i)
                        {
                            union.Union(dict[mail], i);
                        }
                    }
                    else
                    {
                        
                        dict.Add(mail, i);
                    }
                }
            }

            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                int root = union.Find(i);
                if (map.ContainsKey(root))
                {
                    map[root].Add(i);
                }
                else
                {
                    map.Add(root, new List<int>() { i });
                }

            }

            List<IList<string>> res = new List<IList<string>>();

            foreach (var item in map.Values)
            {

                string name = accounts[item[0]][0];
                HashSet<string> set = new HashSet<string>();
                List<string> list = new List<string>();
                list.Add(name);
                foreach (int i in item)
                {
                    var mails = accounts[i];
                    for (int j = 1; j < mails.Count; j++)
                    {
                        set.Add(mails[j]);
                    }

                }

                var ls = set.ToList();
                ls.Sort(string.CompareOrdinal);
                list.AddRange(ls);
                res.Add(list);
            }


            return res;
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
