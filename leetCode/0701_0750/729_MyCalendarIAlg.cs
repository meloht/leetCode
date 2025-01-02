﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _729_MyCalendarIAlg
    {
        public class MyCalendar
        {
            SortedSet<int[]> booked;
            public MyCalendar()
            {
                booked = new SortedSet<int[]>(Comparer<int[]>.Create((x, y) => x[0] - y[0]));
            }

            public bool Book(int startTime, int endTime)
            {
                if (booked.Count == 0)
                {
                    booked.Add([startTime, endTime]);
                    return true;
                }

                if (startTime >= booked.Max()[1] || endTime <= booked.Min()[0])
                {
                    booked.Add([startTime, endTime]);
                    return true;
                }

                var right = booked.GetViewBetween([endTime, 0], [int.MaxValue, 0]).Min;
                var left = booked.GetViewBetween([0, 0], [endTime, 0]).Max;

                if (left != null && left[1] <= startTime)
                {
                    if (right == null || right[0] >= endTime)
                    {
                        booked.Add([startTime, endTime]);
                        return true;
                    }

                }

                else
                {
                    if (right != null && right[0] >= endTime)
                    {
                        booked.Add([startTime, endTime]);
                        return true;
                    }
                }

                return false;
            }


        }


    }
}
