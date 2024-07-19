using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3096_MinimumLevelsToGainMorePointsAlg
    {
        public int MinimumLevels(int[] possible)
        {
            int[] sums = new int[possible.Length];
            sums[0] = possible[0];
            int n = possible.Length;
            for (int i = 1; i < n; i++)
            {
                sums[i] = sums[i - 1] + possible[i];
            }

            for (int i = 0; i < n; i++)
            {
                int n1 = sums[i];
                int s1 = n1 - (i + 1 - n1);
                int n2 = sums[n - 1] - sums[i];

                int s2 = n2 - (n - i - 1 - n2);
                if (s1 > s2 && i + 1 < n)
                {
                    return i + 1;
                }
            }


            return -1;
        }

        public int MinimumLevels1(int[] possible)
        {
            int n = possible.Length;
            int tot = 0;
            foreach (int x in possible)
            {
                tot += x == 1 ? 1 : -1;
            }
            int pre = 0;
            for (int i = 0; i < n - 1; i++)
            {
                pre += possible[i] == 1 ? 1 : -1;
                if (2 * pre > tot)
                {
                    return i + 1;
                }
            }
            return -1;
        }



    }
}
