using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _855_ExamRoomAlg
    {
        public class ExamRoom
        {
            PriorityQueue<int[], int[]> priorityQueue;
            private int n;
            private SortedSet<int> seats;
            public ExamRoom(int n)
            {
                this.n = n;
                seats = new SortedSet<int>();
                priorityQueue = new PriorityQueue<int[], int[]>(Comparer<int[]>.Create((p1, p2) => {

                    int d1 = p1[1] - p1[0], d2 = p2[1] - p2[0];
                    return d1 / 2 == d2 / 2 ? (p1[0] > p2[0] ? 1 : -1) : (d1 / 2 < d2 / 2 ? 1 : -1);
                }));
            }

            public int Seat()
            {
                if (seats.Count == 0)
                {
                    seats.Add(0);
                    return 0;
                }
                int left = seats.Min, right = n - 1 - seats.Max;

                while (seats.Count >= 2)
                {
                    var p = priorityQueue.Peek();
                    if (seats.Contains(p[0]) && seats.Contains(p[1]) && seats.GetViewBetween(p[0] + 1, n - 1).Min == p[1])
                    { // 不属于延迟删除的区间
                        int d = p[1] - p[0];
                        if (d / 2 < right || d / 2 <= left)
                        { // 最左或最右的座位更优
                            break;
                        }
                        priorityQueue.Dequeue();
                        priorityQueue.Enqueue(new int[] { p[0], p[0] + d / 2 }, new int[] { p[0], p[0] + d / 2 });
                        priorityQueue.Enqueue(new int[] { p[0] + d / 2, p[1] }, new int[] { p[0] + d / 2, p[1] });
                        seats.Add(p[0] + d / 2);
                        return p[0] + d / 2;
                    }
                    priorityQueue.Dequeue(); // leave 函数中延迟删除的区间在此时删除
                }
                if (right > left)
                { // 最右的位置更优
                    priorityQueue.Enqueue(new int[] { seats.Max, n - 1 }, new int[] { seats.Max, n - 1 });
                    seats.Add(n - 1);
                    return n - 1;
                }
                else
                {
                    priorityQueue.Enqueue(new int[] { 0, seats.Min }, new int[] { 0, seats.Min });
                    seats.Add(0);
                    return 0;
                }



            }

            public void Leave(int p)
            {
                if (p != seats.Min && p != seats.Max)
                {
                    int prev = seats.GetViewBetween(0, p - 1).Max;
                    int next = seats.GetViewBetween(p + 1, n - 1).Min;
                    priorityQueue.Enqueue(new int[] { prev, next }, new int[] { prev, next });
                }
                seats.Remove(p);


            }
        }
    }
}
