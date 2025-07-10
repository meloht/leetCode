using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3439_RescheduleMeetingsForMaximumFreeTimeIAlg
    {
        public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
        {
            int ans = 0;
            int s = 0;
            for (int i = 0; i <= startTime.Length; i++)
            {
                s += get(i, eventTime, startTime, endTime);
                if (i < k)
                {
                    continue;
                }
                ans = Math.Max(ans, s);
                s -= get(i - k, eventTime, startTime, endTime);
            }
            return ans;
        }
        private int get(int i, int eventTime, int[] startTime, int[] endTime)
        {
            if (i == 0)
            {
                return startTime[0]; // 最左边的空余时间段
            }
            int n = startTime.Length;
            if (i == n)
            {
                return eventTime - endTime[n - 1]; // 最右边的空余时间段
            }
            return startTime[i] - endTime[i - 1]; // 中间的空余时间段
        }


    }
}
