using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2501_2550
{
    public class _2549_CountDistinctNumbersOnBoardAlg
    {
        public int DistinctIntegers1(int n)
        {
            HashSet<int> result = new HashSet<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            result.Add(n);
            while (queue.Count > 0)
            {
                int num = queue.Dequeue();

                for (int j = 1; j <= num; j++)
                {
                    if (num % j == 1 && result.Add(j))
                    {
                        queue.Enqueue(j);
                    }

                }
            }
            return result.Count;
        }
        public int DistinctIntegers(int n)
        {
            return n == 1 ? 1 : n - 1;
        }


    }
}
