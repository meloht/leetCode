using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2451_2500
{
    public class _2462_TotalCostToHireKWorkersAlg
    {
        public long TotalCost(int[] costs, int k, int candidates)
        {
            int n = costs.Length;
    
            PriorityQueue<Tuple<int, int>, int[]> pq = new PriorityQueue<Tuple<int, int>, int[]>(new MyCompare());


            int left = candidates - 1, right = n - candidates;
            if (left + 1 < right)
            {
                for (int i = 0; i <= left; ++i)
                {
                    pq.Enqueue(new Tuple<int, int>(costs[i], i), [costs[i], i]);
                }
                for (int i = right; i < n; ++i)
                {
                    pq.Enqueue(new Tuple<int, int>(costs[i], i), [costs[i], i]);
                }
            }
            else
            {
                for (int i = 0; i < n; ++i)
                {
                    pq.Enqueue(new Tuple<int, int>(costs[i], i), [costs[i], i]);
                }
            }
            long ans = 0;
            for (int i = 0; i < k; ++i)
            {
                Tuple<int, int> pair = pq.Dequeue();
                int cost = pair.Item1, id = pair.Item2;
                ans += cost;
                if (left + 1 < right)
                {
                    if (id <= left)
                    {
                        ++left;
                        pq.Enqueue(new Tuple<int, int>(costs[left], left), [costs[left], left]);
                    }
                    else
                    {
                        --right;
                        pq.Enqueue(new Tuple<int, int>(costs[right], right), [costs[right], right]);
                    }
                }
            }
            return ans;
           
        }

        public class MyCompare : IComparer<int[]>
        {
            public int Compare(int[]? x, int[]? y)
            {
                return x[0] == y[0] ? x[1].CompareTo(y[1]) : x[0].CompareTo(y[0]);
            }
        }
      

    }
}
