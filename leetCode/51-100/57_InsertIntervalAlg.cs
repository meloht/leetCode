using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace leetCode._51_100
{
    public class _57_InsertIntervalAlg
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if (intervals == null || intervals.Length == 0)
                return new int[][] { newInterval };
            List<int[]> result = new List<int[]>();
            int i = 0;
            int[] currentMerge = newInterval;
            bool flag = false;
            bool isAdd = false;
            while (i < intervals.Length)
            {
                int begin = intervals[i][0];
                int end = intervals[i][1];
                if (currentMerge[1] < begin && flag == false)
                {
                    isAdd = true;
                    flag = true;
                    result.Add(currentMerge);
                    result.Add(intervals[i]);
                   
                }
                else if (currentMerge[1] >= begin && currentMerge[1] <= end)
                {
                    intervals[i][0] = Math.Min(currentMerge[0], begin);
                    currentMerge = intervals[i];

                    flag = true;

                    if (i == intervals.Length - 1)
                    {
                        if (isAdd == false)
                        {
                            isAdd = true;
                            result.Add(currentMerge);
                        }
                        break;
                    }
                }
                else if (currentMerge[1] > end && currentMerge[0] <= end)
                {
                    intervals[i][0] = Math.Min(currentMerge[0], begin);
                    intervals[i][1] = Math.Max(currentMerge[1], end);
                    currentMerge = intervals[i];
                    flag = true;
                    if (i == intervals.Length - 1)
                    {
                        if (isAdd == false)
                        {
                            isAdd = true;
                            result.Add(currentMerge);
                        }
                        break;
                    }
                }
                else if (currentMerge[0] > end)
                {
                    result.Add(intervals[i]);
                    if (i == intervals.Length - 1 && flag == false)
                    {
                        if (isAdd == false)
                        {
                            isAdd = true;
                            result.Add(currentMerge);
                        }
                        break;
                    }
                }
                else if (currentMerge[1] < begin && flag == true)
                {
                    if (isAdd == false)
                    {
                        isAdd = true;
                        result.Add(currentMerge);
                    }
                  
                    result.Add(intervals[i]);
                }
                i++;
            }

            return result.ToArray();
        }
    }
}
