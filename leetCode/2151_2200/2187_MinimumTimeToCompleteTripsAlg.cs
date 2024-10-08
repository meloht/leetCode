﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2151_2200
{
    public class _2187_MinimumTimeToCompleteTripsAlg
    {
        public long MinimumTime(int[] time, int totalTrips)
        {
            // 判断 t 时间内是否可以完成 totalTrips 趟旅途
            bool Check(long t)
            {
                long cnt = 0;
                foreach (int period in time)
                {
                    cnt += t / period;
                }
                return cnt >= totalTrips;
            }

            // 二分查找下界与上界
            long l = 1;
            long r = (long)totalTrips * time.Max();
            // 二分查找寻找满足要求的最小的 t
            while (l < r)
            {
                long mid = l + (r - l) / 2;
                if (Check(mid))
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;
        }

    }
}
