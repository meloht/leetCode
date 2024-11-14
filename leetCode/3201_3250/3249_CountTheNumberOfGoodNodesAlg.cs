using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3201_3250
{
    
    public class _3249_CountTheNumberOfGoodNodesAlg
    {
        private int ans;
        public int CountGoodNodes(int[][] edges)
        {
            int n = edges.Length + 1;
            List<int>[] g = new List<int>[n];
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
            dfs(0, -1, g);
            return ans;

        }

        private int dfs(int x, int fa, List<int>[] g)
        {
            int size = 1;
            int sz0 = 0;
            bool ok = true;
            foreach (int y in g[x])
            {
                if (y == fa)
                {
                    continue; // 不能递归到父节点
                }
                int sz = dfs(y, x, g);
                if (sz0 == 0)
                {
                    sz0 = sz; // 记录第一个儿子子树的大小
                }
                else if (sz != sz0)
                { // 存在大小不一样的儿子子树
                    ok = false; // 注意不能 break，其他子树 y 仍然要递归
                }
                size += sz;
            }
            ans += ok ? 1 : 0;
            return size;
        }


    }
}
