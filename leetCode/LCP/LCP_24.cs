using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.LCP
{
    public class LCP_24
    {
        int Mod = 1_000_000_007;
        public int[] NumsGame(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];

            PriorityQueue<int, int> lower = new PriorityQueue<int, int>();
            PriorityQueue<int, int> upper = new PriorityQueue<int, int>();

            long lowerSum = 0;
            long upperSum = 0;
            for (int i = 0; i < n; i++)
            {
                int x = nums[i] - i;
                if (lower.Count == 0 || lower.Peek() >= x)
                {
                    lowerSum += x;
                    lower.Enqueue(x, -x);
                    if (lower.Count > upper.Count + 1)
                    {
                        int num = lower.Dequeue();
                        upperSum += num;
                        upper.Enqueue(num, num);
                        lowerSum -= num;
                    }
                }
                else
                {
                    upperSum += x;
                    upper.Enqueue(x, x);
                    if (lower.Count < upper.Count)
                    {
                        int num = upper.Dequeue();
                        lowerSum += num;
                        lower.Enqueue(num, -num);
                        upperSum -= num;
                    }
                }

                if ((i + 1) % 2 == 0)
                {
                    res[i] = (int)((upperSum - lowerSum) % Mod);
                }
                else
                {
                    res[i] = (int)((upperSum - lowerSum + lower.Peek()) % Mod);
                }

            }

            return res;
        }

    }
}
