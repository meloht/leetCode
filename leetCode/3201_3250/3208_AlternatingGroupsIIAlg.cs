using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3208_AlternatingGroupsIIAlg
    {
        public int NumberOfAlternatingGroups(int[] colors, int k)
        {
            int n = colors.Length;
            int ans = 0;
            int cnt = 0;
            for (int i = 0; i < n + k - 1; i++)
            {
                if (i > 0 && colors[i % n] == colors[(i - 1) % n])
                {
                    cnt = 0;
                }
                cnt++;
                if (cnt >= k)
                {
                    ans++;
                }
            }
            return ans;

        }
    }
}
