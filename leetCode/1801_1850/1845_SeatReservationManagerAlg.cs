using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1801_1850
{
    public class _1845_SeatReservationManagerAlg
    {
        public class SeatManager
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            public SeatManager(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    queue.Enqueue(i, i);
                }
            }

            public int Reserve()
            {
                return queue.Dequeue();
            }

            public void Unreserve(int seatNumber)
            {
                queue.Enqueue(seatNumber, seatNumber);
            }
        }
    }
}
