using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_4000
{
    public class _3184_CountPairsThatFormACompleteDayIAlg
    {
        public int CountCompleteDayPairs(int[] hours)
        {
            int ans = 0;
            for (int i = 0; i < hours.Length; i++)
            {
                for (int j = i + 1; j < hours.Length; j++)
                {
                    int num = hours[i] + hours[j];
                    if (num >= 24 && num % 24 == 0)
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}
