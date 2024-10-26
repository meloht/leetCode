using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _526_BeautifulArrangementAlg
    {
        public int CountArrangement(int n)
        {
            int[] f = new int[1 << n];
            f[0] = 1;
            for (int s = 1; s < 1 << n; s++)
            {
                int i = int.PopCount(s);
                for (int j = 1; j <= n; j++)
                {
                    if ((s >> (j - 1) & 1) != 0 && (i % j == 0 || j % i == 0))
                    {
                        f[s] += f[s ^ (1 << (j - 1))];
                    }
                }
            }
            return f[(1 << n) - 1];


        }
    }
}
