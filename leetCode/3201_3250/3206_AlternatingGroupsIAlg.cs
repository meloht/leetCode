using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3206_AlternatingGroupsIAlg
    {
        public int NumberOfAlternatingGroups(int[] colors)
        {
            int ans = 0;
            for (int i = 0; i < colors.Length; i++)
            {
                if (i == 0)
                {
                    if (colors[colors.Length - 1] != colors[0] && colors[0] != colors[1])
                    {
                        ans++;
                    }
                }
                else if (i == colors.Length - 1)
                {
                    if (colors[i] != colors[0] && colors[i] != colors[i - 1])
                    {
                        ans++;
                    }
                }
                else
                {
                    if (colors[i] != colors[i-1] && colors[i] != colors[i + 1])
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}
