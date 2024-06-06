using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _397_IntegerReplacementAlg
    {
        public int IntegerReplacement(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int ans = Dfs(n, dict);

            return ans;
        }

        private int Dfs(int n, Dictionary<int, int> dict)
        {
            if (n == 1)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            if (n == 3)
            {
                return 2;
            }
            if (dict.ContainsKey(n))
            {
                return dict[n];
            }
            int ans = 0;
            if (n % 2 == 0)
            {
                ans = Dfs(n / 2, dict) + 1;
            }
            else
            {
                int num1 = Dfs(n / 2, dict) + 2;
                int num2 = Dfs(n / 2 + 1, dict) + 2;
                ans = Math.Min(num1, num2);
            }
            dict.Add(n, ans);
            return ans;
        }
    }
}
