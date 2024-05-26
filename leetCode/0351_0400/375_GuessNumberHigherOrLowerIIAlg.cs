using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _375_GuessNumberHigherOrLowerIIAlg
    {
        static int N = 210;
        int[,] cache = new int[N, N];
        public int GetMoneyAmount(int n)
        {

            return Dfs(1, n);
        }
        private int Dfs(int l, int r)
        {
            if (l >= r) return 0;
            if (cache[l, r] != 0) return cache[l, r];
            int ans = int.MaxValue;
            for (int x = l; x <= r; x++)
            {
                // 当选择的数位 x 时，至少需要 cur 才能猜中数字
                int cur = Math.Max(Dfs(l, x - 1), Dfs(x + 1, r)) + x;
                // 在所有我们可以决策的数值之间取最优
                ans = Math.Min(ans, cur);
            }
            cache[l, r] = ans;
            return ans;
        }

    }
}
