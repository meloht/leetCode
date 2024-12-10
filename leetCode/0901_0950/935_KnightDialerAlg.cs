using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _935_KnightDialerAlg
    {
        int Mod = 1_000_000_007;
        int[][] moves = [
            [4, 6],
            [6, 8],
            [7, 9],
            [4, 8],
            [3, 9, 0],
            [],
            [1, 7, 0],
            [2, 6],
            [1, 3],
            [2, 4]];

        private int[,] memo = new int[5000,10];

        public int KnightDialer(int n)
        {
            if (n == 1) 
            {
                return 10;
            }
            int ans = 0;
            for (int i = 0; i < 10; i++)
            {
                ans = (ans + Dfs(n - 1, i)) % Mod;
            }
           
            return ans;
        }

        private int Dfs(int i,int j)
        {
            if (i == 0)
            {
                return 1;
            }
            if (memo[i, j] > 0)
            {
                return memo[i, j];
            }
            int res = 0;
           
            foreach (int k in moves[j])
            {
                res = (res + Dfs(i - 1,k)) % Mod;
            }

            memo[i, j] = res;
            return res;
        }
    }
}
