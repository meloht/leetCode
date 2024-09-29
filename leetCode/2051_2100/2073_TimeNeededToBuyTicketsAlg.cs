using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2051_2100
{
    public class _2073_TimeNeededToBuyTicketsAlg
    {
        public int TimeRequiredToBuy1(int[] tickets, int k)
        {
            int ans = 0;
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < tickets.Length; i++)
            {
                q.Enqueue(i);
            }
            while (q.Count > 0)
            {
                ans++;
                int i = q.Dequeue();
                tickets[i]--;
                if (tickets[i] == 0)
                {
                    if (i == k)
                    {
                        return ans;
                    }
                }
                else
                {
                    q.Enqueue(i);
                }
            }

            return 0;
        }

        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            int n = tickets.Length;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                // 遍历计算每个人所需时间
                if (i <= k)
                {
                    res += Math.Min(tickets[i], tickets[k]);
                }
                else
                {
                    res += Math.Min(tickets[i], tickets[k] - 1);
                }
            }
            return res;
        }


    }
}
