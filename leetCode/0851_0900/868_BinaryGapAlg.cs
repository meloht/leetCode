using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _868_BinaryGapAlg
    {
        public int BinaryGap(int n)
        {
            string s = Convert.ToString(n, 2);
            int ans = 0;
            int i = 0;
            int j = 0;
            while (i < s.Length)
            {
                if (s[i] == '1')
                {
                    j = i + 1;
                    while (j < s.Length)
                    {
                        if (s[j] == '1')
                        {
                            ans = Math.Max(ans, j - i);
                            i = j;
                            break;
                        }
                        j++;
                    }
                    i = j;
                    continue;
                }
                i++;
            }

            return ans;
        }
    }
}
