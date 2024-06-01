using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2928_DistributeCandiesAmongChildrenIAlg
    {
        public int DistributeCandies1(int n, int limit)
        {
            int ans = 0;
            for (int i = 0; i <= limit; i++)
            {
                for (int j = 0; j <= limit; j++)
                {
                    if (i + j > n)
                    {
                        break;
                    }
                    if (n - i - j <= limit)
                    {
                        ans++;
                    }
                }
            }
            return ans;

        }
        public int DistributeCandies(int n, int limit)
        {
            int ans = 0;
            for (int i = 0; i <= Math.Min(limit, n); i++)
            {
                if (n - i > 2 * limit)
                {
                    continue;
                }
                ans += Math.Min(n - i, limit) - Math.Max(0, n - i - limit) + 1;
            }
            return ans;
        }



    }
}
