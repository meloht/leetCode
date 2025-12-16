using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3551_3600
{
    public class _3562_MaximumProfitFromTradingStocksWithDiscountsAlg
    {
        public int MaxProfit(int n, int[] present, int[] future, int[][] hierarchy, int budget)
        {
            List<int>[] g=new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                g[i] = new List<int>();
            }
            foreach (int[] e in hierarchy)
            {
                g[e[0] - 1].Add(e[1] - 1);
            }

            int[][] f0 = dfs(0, g, present, future, budget);
            return f0[budget][0];
        }

        private int[][] dfs(int x, List<int>[] g, int[] present, int[] future, int budget)
        {
            // 计算从 x 的所有儿子子树 y 中，能得到的最大利润之和（x 不买，x 买）
            int[][] subF = new int[budget + 1][];
            for (int i = 0; i <= budget; i++)
            {
                subF[i] = new int[2];
            }
            foreach (int y in g[x])
            {
                int[][] fy = dfs(y, g, present, future, budget);
                for (int j = budget; j >= 0; j--)
                {
                    // 枚举子树 y 的预算为 jy
                    // 当作一个体积为 jy，价值为 fy[jy][k] 的物品
                    for (int jy = 0; jy <= j; jy++)
                    {
                        for (int k = 0; k < 2; k++)
                        { // k=0 表示 x 不买，k=1 表示 x 买
                            subF[j][k] = Math.Max(subF[j][k], subF[j - jy][k] + fy[jy][k]);
                        }
                    }
                }
            }

            // 计算从子树 x 中，能得到的最大利润之和（x 父节点不买，x 父节点买）
            int[][] f = new int[budget + 1][];
            for (int i = 0; i <= budget; i++)
            {
                f[i] = new int[2];
            }
            for (int j = 0; j <= budget; j++)
            {
                for (int k = 0; k < 2; k++)
                { // k=0 表示 x 父节点不买，k=1 表示 x 父节点买
                    int cost = present[x] / (k + 1);
                    if (j >= cost)
                    {
                        // 不买 x，转移来源是 subF[j][0]
                        // 买 x，转移来源为 subF[j-cost][1]，因为对于子树来说，父节点一定买
                        f[j][k] = Math.Max(subF[j][0], subF[j - cost][1] + future[x] - cost);
                    }
                    else
                    { // 只能不买 x
                        f[j][k] = subF[j][0];
                    }
                }
            }
            return f;
        }

    }
}
