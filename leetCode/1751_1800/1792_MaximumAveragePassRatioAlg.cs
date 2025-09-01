﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1751_1800
{
    public class _1792_MaximumAveragePassRatioAlg
    {
        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            var pq = new PriorityQueue<int[], double>(Comparer<double>.Create((a, b) => b.CompareTo(a)));
            foreach (var c in classes)
            {
                double priority = GetPriority(c);
                pq.Enqueue(c, priority);
            }
            for (; extraStudents > 0; extraStudents--)
            {
                var current = pq.Dequeue();
                current[0]++;
                current[1]++;
                double newPriority = GetPriority(current);
                pq.Enqueue(current, newPriority);
            }
            double res = 0;
            while (pq.Count > 0)
            {
                var c = pq.Dequeue();
                res += (double)c[0] / c[1];
            }

            return res / classes.Length;
        }

        private double GetPriority(int[] c)
        {
            int pass = c[0];
            int total = c[1];
            return (double)(total - pass) / (total * (total + 1L));
        }


    }
}
