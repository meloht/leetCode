using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _851_LoudAndRichAlg
    {

        public int[] LoudAndRich1(int[][] richer, int[] quiet)
        {
            int n = quiet.Length;
            List<int>[] adjList = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                adjList[i] = new List<int>();
            }
            for (int i = 0; i < richer.Length; i++)
            {
                adjList[richer[i][1]].Add(richer[i][0]);
            }

            int[] ans = new int[n];
            Array.Fill(ans, -1);

            for (int i = 0; i < n; i++)
            {
                Dfs(adjList, i, quiet, ans);
            }

            return ans;
        }

        private void Dfs(List<int>[] adjList, int val, int[] quiet, int[] ans)
        {
            if (ans[val] != -1)
                return;

            ans[val] = val;
            var ls = adjList[val];

            foreach (var item in ls)
            {

                Dfs(adjList, item, quiet, ans);
                if (quiet[ans[item]] < quiet[ans[val]])
                {
                    ans[val] = ans[item];
                }
            }

        }

        public int[] LoudAndRich(int[][] richer, int[] quiet)
        {
            int n = quiet.Length;

            int[] ans = new int[n];

            List<int>[] g = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                g[i] = new List<int>();
            }

            int[] inDeg = new int[n];

            foreach (var item in richer)
            {
                g[item[0]].Add(item[1]);
                inDeg[item[1]]++;
            }
            for (int i = 0; i < n; i++)
            {
                ans[i] = i;
            }

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (inDeg[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count > 0)
            {
                int x = queue.Dequeue();
                foreach (int y in g[x])
                {
                    if (quiet[ans[x]] < quiet[ans[y]])
                    {
                        ans[y] = ans[x];
                    }
                    inDeg[y]--;
                    if (inDeg[y] == 0)
                    {
                        queue.Enqueue(y);
                    }
                }
            }
            return ans;
        }


    }
}
