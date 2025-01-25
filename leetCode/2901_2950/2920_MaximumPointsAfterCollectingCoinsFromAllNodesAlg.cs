using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2901_2950
{
    public class _2920_MaximumPointsAfterCollectingCoinsFromAllNodesAlg
    {
        public int MaximumPoints1(int[][] edges, int[] coins, int k)
        {
            int n = coins.Length;
            List<int>[] graph = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }
            foreach (int[] edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }
            int[][] memo = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] arr = new int[14];
                Array.Fill(arr, -1);
                memo[i] = arr;
            }

            return dfs(0, 0, -1, memo, graph, coins, k);
        }

        private int dfs(int i, int j, int fa, int[][] memo, List<int>[] g, int[] coins, int k)
        {
            if (memo[i][j] != -1)
            { // 之前计算过
                return memo[i][j];
            }
            int res1 = (coins[i] >> j) - k;
            int res2 = coins[i] >> (j + 1);
            foreach (int ch in g[i])
            {
                if (ch == fa) continue;
                res1 += dfs(ch, j, i, memo, g, coins, k); // 不右移
                if (j < 13)
                { // j+1 >= 14 相当于 res2 += 0，无需递归
                    res2 += dfs(ch, j + 1, i, memo, g, coins, k); // 右移
                }
            }
            return memo[i][j] = Math.Max(res1, res2); // 记忆化
        }

        public int MaximumPoints(int[][] edges, int[] coins, int k)
        {
            int n = coins.Length;
            List<int>[] graph = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }
            foreach (int[] edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }
            return dfs(0, -1, graph, coins, k)[0];
        }



        private int[] dfs(int x, int fa, List<int>[] g, int[] coins, int k)
        {
            int[] s = new int[14];
            foreach (int y in g[x])
            {
                if (y == fa) continue;
                int[] fy = dfs(y, x, g, coins, k);
                for (int j = 0; j < 14; j++)
                {
                    s[j] += fy[j];
                }
            }
            for (int j = 0; j < 13; j++)
            {
                s[j] = Math.Max((coins[x] >> j) - k + s[j], (coins[x] >> (j + 1)) + s[j + 1]);
            }
            s[13] += (coins[x] >> 13) - k;
            return s;
        }




    }
}
