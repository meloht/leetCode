using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1851_1900
{
    public class _1857_LargestColorValueInADirectedGraphAlg
    {
        public int LargestPathValue(string colors, int[][] edges)
        {
            int n = colors.Length;
            // 邻接表
            List<List<int>> g = new List<List<int>>();
            for (int i = 0; i < n; ++i)
            {
                g.Add(new List<int>());
            }
            // 节点的入度统计，用于找出拓扑排序中最开始的节点
            int[] indeg = new int[n];
            foreach (var edge in edges)
            {
                ++indeg[edge[1]];
                g[edge[0]].Add(edge[1]);
            }
            // 记录拓扑排序过程中遇到的节点个数
            // 如果最终 found 的值不为 n，说明图中存在环
            int found = 0;
            int[][] f = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                f[i] = new int[26];
            }
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < n; ++i)
            {
                if (indeg[i] == 0)
                {
                    q.Enqueue(i);
                }
            }
            while (q.Count > 0)
            {
                ++found;
                int u = q.Dequeue();
                // 将节点 u 对应的颜色增加 1
                ++f[u][colors[u] - 'a'];
                // 枚举 u 的后继节点 v
                foreach (int v in g[u])
                {
                    --indeg[v];
                    // 将 f(v,c) 更新为其与 f(u,c) 的较大值
                    for (int c = 0; c < 26; ++c)
                    {
                        f[v][c] = Math.Max(f[v][c], f[u][c]);
                    }
                    if (indeg[v] == 0)
                    {
                        q.Enqueue(v);
                    }
                }
            }
            if (found != n)
            {
                return -1;
            }
            int ans = 0;
            for (int i = 0; i < n; ++i)
            {
                ans = Math.Max(ans, f[i].Max());
            }
            return ans;

        }
    }
}
