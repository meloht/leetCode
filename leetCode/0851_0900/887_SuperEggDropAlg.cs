using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _887_SuperEggDropAlg
    {
        public int SuperEggDrop(int k, int n)
        {
            int[] f = new int[k + 1];
            for (int i = 1; ; i++)
            {
                for (int j = k; j > 0; j--)
                {
                    f[j] += f[j - 1] + 1;
                }
                if (f[k] >= n)
                {
                    return i;
                }
            }

        }
    }
}
