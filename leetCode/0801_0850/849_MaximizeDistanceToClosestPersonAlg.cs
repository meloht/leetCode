using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _849_MaximizeDistanceToClosestPersonAlg
    {
        public int MaxDistToClosest(int[] seats)
        {
            int ans = 0;
            int pre = 0;
            bool st = seats[0] == 0;
            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 0)
                {
                    pre++;
                }
                if (seats[i] == 1)
                {
                    if (st)
                    {
                        st = false;
                        ans = Math.Max(ans, pre);
                    }
                    else
                    {
                        if (pre % 2 == 1)
                        {
                            ans = Math.Max(ans, pre / 2 + 1);
                        }
                        else
                        {
                            ans = Math.Max(ans, pre / 2 );
                        }
                    }
                    pre = 0;
                }
                if (i == seats.Length - 1)
                {
                    ans = Math.Max(ans, pre);
                }
            }

            return ans;
        }
    }
}
