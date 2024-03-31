using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2201_2250
{
    public class _2246_LongestPathWithDifferentAdjacentCharactersAlg
    {
        List<int>[] list;
        string s;
        int ans = 0;
        public int LongestPath(int[] parent, string s)
        {
            this.s = s;
            int n = parent.Length;
            list = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                list[i] = new List<int>();
            }

            for (int i = 1; i < n; i++)
            {
                list[parent[i]].Add(i);
            }
            Dfs(0);
            return ans + 1;
        }
        private int Dfs(int x)
        {
            int maxLen = 0;
            for (int i = 0; i < list[x].Count; i++)
            {
                int y = list[x][i];
                var len = Dfs(y) + 1;
                if (s[y] != s[x])
                {
                    ans = Math.Max(ans, maxLen + len);
                    maxLen = Math.Max(maxLen, len);
                }
            }
            return maxLen;
        }


        //int N = 100010, M = 100010, idx = 0, ans = 1;
        //int[] he = new int[100010], e = new int[100010], ne = new int[100010];
        //char[] cs;
        //void add(int a, int b)
        //{
        //    e[idx] = b;
        //    ne[idx] = he[a];
        //    he[a] = idx++;
        //}
        //public int LongestPath(int[] parent, string s)
        //{
        //    Array.Fill(he, -1);
        //    for (int i = 1; i < parent.Length; i++) add(parent[i], i);
        //    cs = s.ToCharArray();
        //    dfs(0);
        //    return ans;
        //}
        //int dfs(int u)
        //{
        //    int res = 0;
        //    int l1 = 0, l2 = 0;
        //    for (int i = he[u]; i != -1; i = ne[i])
        //    {
        //        int j = e[i];
        //        int t = dfs(j);
        //        if (cs[u] == cs[j]) continue;
        //        if (t > l1)
        //        {
        //            l2 = l1; l1 = t;
        //        }
        //        else if (t > l2)
        //        {
        //            l2 = t;
        //        }
        //        res = Math.Max(res, t);
        //        ans = Math.Max(ans, 1 + l1 + l2);
        //    }
        //    return res + 1;
        //}


    }
}
