using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _948_BagOfTokensAlg
    {
        public int BagOfTokensScore(int[] tokens, int power)
        {
            int ans = 0;
            Array.Sort(tokens);
            int num = 0;
            for (int i = 0, j = tokens.Length - 1; i <= j;)
            {
                if (power >= tokens[i])
                {
                    num++;
                    power -= tokens[i];
                    ans = Math.Max(ans, num);
                    i++;
                }
                else if (num > 0)
                {
                    power += tokens[j];
                    j--;
                    num--;

                }
                else
                {
                    return ans;
                }
            }

            return ans;

        }


    }
}
