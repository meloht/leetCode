using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2274_MaximumConsecutiveFloorsWithoutSpecialFloorsAlg
    {
        public int MaxConsecutive(int bottom, int top, int[] special)
        {
            Array.Sort(special);

            int ans = special[0] - bottom;
            for (int i = 1; i < special.Length; i++)
            {
                ans = Math.Max(ans, special[i] - special[i - 1] - 1);
            }
            ans = Math.Max(ans, top - special[special.Length - 1]);

            return ans;
        }
    }
}
