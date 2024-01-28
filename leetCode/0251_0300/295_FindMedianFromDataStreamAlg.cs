using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _295_FindMedianFromDataStreamAlg
    {
        public class MedianFinder
        {
            PriorityQueue<int, int> queueLow = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
            PriorityQueue<int, int> queueHigh = new PriorityQueue<int, int>();

            private bool isCalc;
            private double db = 0;

            public MedianFinder()
            {

            }

            public void AddNum(int num)
            {
                isCalc = false;
                if (queueLow.Count == 0)
                {
                    queueLow.Enqueue(num, num);
                }
                else
                {
                    if (queueHigh.Count == 0)
                    {
                        if (num >= queueLow.Peek())
                        {
                            queueHigh.Enqueue(num, num);
                        }
                        else
                        {
                            queueLow.Enqueue(num, num);
                            int nn = queueLow.Dequeue();
                            queueHigh.Enqueue(nn, nn);
                        }
                    }
                    else
                    {
                        if (queueLow.Count == queueHigh.Count)
                        {
                            if (queueLow.Peek() >= num)
                            {
                                queueLow.Enqueue(num, num);
                            }
                            else
                            {
                                queueHigh.Enqueue(num, num);
                                int nn = queueHigh.Dequeue();
                                queueLow.Enqueue(nn, nn);
                            }
                        }
                        else
                        {
                            if (queueLow.Peek() >= num)
                            {
                                queueLow.Enqueue(num, num);
                                int nn = queueLow.Dequeue();
                                queueHigh.Enqueue(nn, nn);
                            }
                            else
                            {
                                queueHigh.Enqueue(num, num);
                            }
                        }
                    }
                }

            }

            public double FindMedian()
            {
                if (isCalc)
                {
                    return db;
                }
                isCalc = true;
                if (queueHigh.Count != queueLow.Count)
                {
                    db = queueLow.Peek();
                }
                else
                {
                    double db1 = queueLow.Peek();
                    double db2 = queueHigh.Peek();
                    db = (db1 + db2) / 2;
                }
                return db;
            }

        }



    }
}
