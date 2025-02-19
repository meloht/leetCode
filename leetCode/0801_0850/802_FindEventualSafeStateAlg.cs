using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _802_FindEventualSafeStateAlg
    {
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            int n = graph.Length;
            int[] color = new int[n];
            List<int> res = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (DFS(graph, color, i))
                {
                    res.Add(i);
                }
            }
            return res;
        }
        private bool DFS(int[][] graph, int[] color, int node)
        {
            if (color[node] > 0)
            {
                return color[node] == 2;
            }
            color[node] = 1;
            foreach (var next in graph[node])
            {
                if (color[next] == 2)
                {
                    continue;
                }
                if (color[next] == 1 || !DFS(graph, color, next))
                {
                    return false;
                }
            }
            color[node] = 2;
            return true;
        }

        /// <summary>
        /// 拓扑排序
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public IList<int> EventualSafeNodes1(int[][] graph)
        {
            int n = graph.Length;
            IList<IList<int>> rg = new List<IList<int>>();
            for (int i = 0; i < n; ++i)
            {
                rg.Add(new List<int>());
            }
            int[] inDeg = new int[n];
            for (int x = 0; x < n; ++x)
            {
                foreach (int y in graph[x])
                {
                    rg[y].Add(x);
                }
                inDeg[x] = graph[x].Length;
            }

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; ++i)
            {
                if (inDeg[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }
            while (queue.Count > 0)
            {
                int y = queue.Dequeue();
                foreach (int x in rg[y])
                {
                    if (--inDeg[x] == 0)
                    {
                        queue.Enqueue(x);
                    }
                }
            }

            IList<int> ans = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                if (inDeg[i] == 0)
                {
                    ans.Add(i);
                }
            }
            return ans;
        }

    }
}
