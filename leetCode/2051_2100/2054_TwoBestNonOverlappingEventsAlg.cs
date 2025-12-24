using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2051_2100
{
    public class _2054_TwoBestNonOverlappingEventsAlg
    {
        public int MaxTwoEvents(int[][] events)
        {
            Array.Sort(events, (a, b)=>a[1] - b[1]);

            int ans = 0;
            int size = 0; // 把 events 当作栈
            foreach (int[] e in events)
            {
                int i = search(events, size, e[0]);
                int value = e[2];
                if (i >= 0)
                {
                    ans = Math.Max(ans, value + events[i][2]);
                }
                else
                {
                    ans = Math.Max(ans, value);
                }

                if (size == 0 || value > events[size - 1][2])
                {
                    events[size++] = e;
                }
            }
            return ans;

        }

        // 返回最后一个满足 st[i][1] < target 的 i
        private int search(int[][] st, int right, int target)
        {
            int left = -1;
            while (left + 1 < right)
            { // 开区间二分
                int mid = left + (right - left) / 2;
                if (st[mid][1] < target)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }

    }
}
