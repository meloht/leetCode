using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2851_2900
{
    public class _2872_MaximumNumberOfKDivisibleComponentsAlg
    {
        private int ans;
        public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
        {
            List<int>[] g =new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                g[i] = new List<int>();
            }
            foreach (int[] e in edges)
            {
                int x = e[0];
                int y = e[1];
                g[x].Add(y);
                g[y].Add(x);
            }

            dfs(0, -1, g, values, k);
            return ans;

        }

        // 返回子树 x 的点权和
        private long dfs(int x, int fa, List<int>[] g, int[] values, int k)
        {
            long sum = values[x];
            foreach (int y in g[x])
            {
                if (y != fa)
                { // 避免访问父节点
                  // 加上子树 y 的点权和，得到子树 x 的点权和
                    sum += dfs(y, x, g, values, k);
                }
            }
            ans += sum % k == 0 ? 1 : 0;
            return sum;
        }

    }
}
