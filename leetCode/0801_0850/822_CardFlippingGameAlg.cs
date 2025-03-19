using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _822_CardFlippingGameAlg
    {
        public int Flipgame(int[] fronts, int[] backs)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < fronts.Length; i++)
            {
                if (fronts[i] == backs[i])
                {
                    set.Add(fronts[i]);
                }
            }
            int ans = int.MaxValue;

            foreach (var item in fronts)
            {
                if (!set.Contains(item))
                {
                    ans = Math.Min(ans, item);
                }
            }
            foreach (var item in backs)
            {
                if (!set.Contains(item))
                {
                    ans = Math.Min(ans, item);
                }
            }

            return ans == int.MaxValue ? 0 : ans;
        }
    }
}
