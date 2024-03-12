using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _455_AssignCookiesAlg
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int ans = 0;
            int index = 0;
            for (int i = 0; i < g.Length; i++)
            {
                for (int j = index; j < s.Length; j++)
                {
                    if (s[j] >= g[i])
                    {
                        ans++;
                        index = j + 1;
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
