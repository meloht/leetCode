using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1701_1750
{
    public class _1705_MaximumNumberOfEatenApplesAlg
    {
        public int EatenApples(int[] apples, int[] days)
        {
            int idx = 0;
            int ans = 0;
            PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>();
            for (int i = 0; i < apples.Length; i++)
            {
                if (apples[i] > 0)
                {
                    ans++;
                    if (apples[i] - 1 > 0)
                    {
                        idx = i;
                        int day = i + days[i];

                        queue.Enqueue([apples[i] - 1, day], day);
                        break;
                    }

                }
            }
            idx++;

            while (queue.Count > 0 || queue.Count == 0 && idx < apples.Length)
            {
                while (queue.Count > 0 && queue.Peek()[1] <= idx)
                {
                    queue.Dequeue();
                }
                if (idx < apples.Length)
                {
                    if (apples[idx] > 0)
                    {
                        int day = idx + days[idx];

                        queue.Enqueue([apples[idx], day], day);

                    }
                }

                while (queue.Count == 0 && idx < apples.Length)
                {
                    if (apples[idx] > 0)
                    {
                        int day = idx + days[idx];
                        queue.Enqueue([apples[idx], day], day);
                        break;
                    }
                    idx++;

                }
                if (queue.Count > 0)
                {
                    var item = queue.Peek();
                    if (item[0] == 1)
                    {
                        ans++;
                        queue.Dequeue();
                    }
                    else if (item[0] > 1)
                    {
                        item[0]--;
                        ans++;
                    }
                }
                idx++;

            }

            return ans;
        }
    }
}
