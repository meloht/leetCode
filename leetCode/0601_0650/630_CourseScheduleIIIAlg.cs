using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0601_0650
{
    public class _630_CourseScheduleIIIAlg
    {
        public int ScheduleCourse(int[][] courses)
        {
            Array.Sort(courses, (a, b)=>a[1] - b[1]); // 按照 lastDay 从小到大排序
            PriorityQueue<int,int> pq = new PriorityQueue<int,int>(Comparer<int>.Create((a, b)=>b - a)); // 最大堆
            int day = 0; // 已消耗时间
            foreach(int[] c in courses)
            {
                int duration = c[0];
                int lastDay = c[1];
                if (day + duration <= lastDay)
                { // 没有超过 lastDay，直接学习
                    day += duration;
                    pq.Enqueue(duration,duration);
                }
                else if (pq.Count>0 && duration < pq.Peek())
                { // 该课程的时间比之前的最长时间要短
                  // 反悔，撤销之前 duration 最长的课程，改为学习该课程
                  // 节省出来的时间，能在后面上完更多的课程
                    day -= pq.Dequeue() - duration;
                    pq.Enqueue(duration,duration);
                }
            }
            return pq.Count;

        }
    }
}
