using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1751_1800
{
    public class _1751_MaximumNumberOfEventsThatCanBeAttendedIIAlg
    {
        public int MaxValue(int[][] events, int k)
        {
            // 特判 k=1 的情况可以更快
            if (k == 1)
            {
                int mx = 0;
                foreach (int[] e in events)
                {
                    mx = Math.Max(mx, e[2]);
                }
                return mx;
            }

            Array.Sort(events, (a, b)=>a[1] - b[1]); // 按照结束时间排序
            int n = events.Length;
            int[,] f = new int[n + 1,k + 1];
            for (int i = 0; i < n; i++)
            {
                int p = search(events, i, events[i][0]);
                for (int j = 1; j <= k; j++)
                {
                    f[i + 1,j] = Math.Max(f[i,j], f[p + 1, j - 1] + events[i][2]);
                }
            }
            return f[n,k];


        }

        /// <summary>
        /// 返回 endDay[i] < upper 的最大 i
        /// </summary>
        /// <param name="events"></param>
        /// <param name="right"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        private int search(int[][] events, int right, int upper)
        {
            int left = -1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (events[mid][1] < upper)
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
