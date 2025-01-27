using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _781_RabbitsInForestAlg
    {
        public int NumRabbits(int[] answers)
        {

            Dictionary<int,int> dict = new Dictionary<int, int>();
            int ans = 0;
            foreach (var item in answers)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }

            foreach (var item in dict)
            {
                if (item.Key == item.Value - 1)
                {
                    ans += item.Key + 1;
                }
                else
                {
                    ans += (item.Value + item.Key) / (item.Key + 1) * (item.Key + 1);
                }
            }
            return ans;
        }
    }
}
