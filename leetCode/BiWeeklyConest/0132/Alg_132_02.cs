using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.BiWeeklyConest.bi_132
{
    public class Alg_132_02
    {
        public int FindWinningPlayer(int[] skills, int k)
        {
            int[] ans = new int[skills.Length];

            int max = 0;
            int maxIndex = 0;
            int pre = skills[0];
            int preIndex = 0;
            for (int i = 0; i < skills.Length; i++)
            {
                if (skills[i] > max)
                {
                    max = skills[i];
                    maxIndex = i;
                }
                if (i != 0)
                {
                    if (pre > skills[i])
                    {
                        ans[preIndex]++;
                        if (ans[preIndex] >= k)
                        {
                            return preIndex;
                        }
                    }
                    else
                    {
                        ans[i]++;
                        pre = skills[i];
                        preIndex = i;
                        if (ans[i] >= k)
                        {
                            return i;
                        }
                    }

                }
            }

            return maxIndex;

        }
    }
}
