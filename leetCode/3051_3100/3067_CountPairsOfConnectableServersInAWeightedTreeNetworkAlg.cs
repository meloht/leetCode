using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3067_CountPairsOfConnectableServersInAWeightedTreeNetworkAlg
    {
        public int[] CountPairsOfConnectableServers(int[][] edges, int signalSpeed)
        {
            int n = edges.Length + 1;
          
            List<int[]>[] graph = new List<int[]>[n];
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int[]>();
            }

            foreach (var item in edges)
            {
                int u = item[0];
                int v = item[1];
                int w = item[2];

                graph[u].Add([v, w]);
                graph[v].Add([u, w]);
            }
            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                int pre = 0;
                foreach (var item in graph[i])
                {
                    int ans = Dfs(item[0], i, item[1] % signalSpeed, signalSpeed, graph);
                    res[i] += pre * ans;
                    pre += ans;
                }
            }

            return res;
        }

        private int Dfs(int p,int root,int curr,int signalSpeed, List<int[]>[] graph)
        {
            int res = 0;
            if (curr == 0)
            {
                res++;
            }
            foreach (var item in graph[p])
            {
                int v = item[0];
                int w = item[1];
                if (v != root)
                {
                    res += Dfs(v, p, (curr + w) % signalSpeed, signalSpeed, graph);
                }
            }

            return res;
        }
    }
}
