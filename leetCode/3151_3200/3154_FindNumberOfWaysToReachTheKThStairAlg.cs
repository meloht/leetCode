using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3154_FindNumberOfWaysToReachTheKThStairAlg
    {
        public int WaysToReachStair(int k)
        {
            return Dfs(1, 0, 0, k, new Dictionary<long, int>());
        }

        private int Dfs(int i, int j, int preDown, int k, Dictionary<long, int> dict)
        {
            if (i > k + 1)
            {
                return 0;
            }
            long ii = (long)i;
            long mask = ii << 32 | j << 1 | preDown;
            if (dict.ContainsKey(mask))
            {
                return dict[mask];
            }
            int res = i == k ? 1 : 0;
            res += Dfs(i + (1 << j), j + 1, 0, k, dict);
            if (preDown == 0 && i > 0)
            {
                res += Dfs(i - 1, j, 1, k, dict);
            }

            dict.Add(mask, res);
            return res;
        }
    }
}
