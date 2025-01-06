using System;
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

                if (startTime >= booked.Max[1] || endTime <= booked.Min[0])
                {
                    booked.Add([startTime, endTime]);
                    return true;
                }

                var right = booked.GetViewBetween([startTime + 1, 0], [int.MaxValue, 0]).Min;
                var left = booked.GetViewBetween([0, 0], [startTime, 0]).Max;

                if (left != null && right != null)
                {
                    if (left[1] <= startTime && right[0] >= endTime)
                    {
                        booked.Add([startTime, endTime]);
                        return true;
                    }

                }
                else if (left != null)
                {
                    if (left[1] <= startTime)
                    {
                        booked.Add([startTime, endTime]);
                        return true;
                    }
                }
                else if (right != null)
                {
                    if (right[0] >= endTime)
                    {
                        booked.Add([startTime, endTime]);
                        return true;
                    }
                }

                return false;
            }


        }


        public class MyCalendar1
        {
            private List<(int, int)> bookings;

            public MyCalendar1()
            {
                bookings = new List<(int, int)>();
            }

            public bool Book(int startTime, int endTime)
            {
                var left = 0;
                var right = bookings.Count - 1;
                while (left <= right)
                {
                    var mid = left + (right - left) / 2;
                    var (bookStart, bookEnd) = bookings[mid];
                    if (bookStart < endTime && bookEnd > startTime)
                    {
                        return false;
                    }
                    if (bookStart >= endTime)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                bookings.Insert(left, (startTime, endTime));
                return true;
            }
        }


    }
}
