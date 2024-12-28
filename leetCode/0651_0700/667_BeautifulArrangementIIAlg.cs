using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _667_BeautifulArrangementIIAlg
    {
        public int[] ConstructArray(int n, int k)
        {
            int[] ans = new int[n];
            int idx = 0;
            for (int i = 1; i < n - k; i++)
            {
                ans[idx++] = i;
            }
            for (int i = n-k,j=n; i <= j; i++,j--)
            {
                ans[idx] = i;
                idx++;
                if (i != j)
                {
                    ans[idx] = j;
                    idx++;
                }
            }
            return ans;
        }
    }
}
