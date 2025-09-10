using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1701_1750
{
    public class _1733_MinimumNumberOfPeopleToTeachAlg
    {
        public int MinimumTeachings(int n, int[][] languages, int[][] friendships)
        {
            int m = languages.Length;
            bool[,] learned = new bool[m, n + 1];
            for (int i = 0; i < m; i++)
            {
                foreach (var item in languages[i])
                {
                    learned[i, item] = true;
                }

            }
            bool[] vis = new bool[m];
            int[] cnt = new int[n + 1];

            foreach (var item in friendships)
            {
                int u = item[0] - 1;
                int v = item[1] - 1;
                bool bl = false;
                foreach (var x in languages[u])
                {
                    if (learned[v, x])
                    {
                        bl = true;
                        break;
                    }
                }
                if (!bl)
                {
                    add(u, languages, vis, cnt);
                    add(v, languages, vis, cnt);
                }

            }
            int maxCnt = 0;
            foreach (int c in cnt)
            {
                maxCnt = Math.Max(maxCnt, c);
            }

            return total - maxCnt;


        }
        private int total = 0;

        private int add(int u, int[][] languages, bool[] vis, int[] cnt)
        {
            if (vis[u])
            {
                return total;
            }
            vis[u] = true; // 避免重复统计
            total++;
            foreach (int x in languages[u])
            {
                cnt[x]++;
            }
            return total;
        }

    }
}
