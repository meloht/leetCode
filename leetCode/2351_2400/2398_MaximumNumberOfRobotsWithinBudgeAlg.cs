﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2351_2400
{
    public class _2398_MaximumNumberOfRobotsWithinBudgeAlg
    {
        public int MaximumRobots(int[] chargeTimes, int[] runningCosts, long budget)
        {
            int res = 0;
            int n = chargeTimes.Length;
            long runningCostSum = 0;
            LinkedList<int> q = new LinkedList<int>();
            for (int i = 0, j = 0; i < n; i++)
            {
                runningCostSum += runningCosts[i];
                while (q.Count > 0 && chargeTimes[q.Last.Value] <= chargeTimes[i])
                {
                    q.RemoveLast();
                }
                q.AddLast(i);
                while (j <= i && (i - j + 1) * runningCostSum + chargeTimes[q.First.Value] > budget)
                {
                    if (q.Count > 0 && q.First.Value == j)
                    {
                        q.RemoveFirst();
                    }
                    runningCostSum -= runningCosts[j];
                    j++;
                }
                res = Math.Max(res, i - j + 1);
            }
            return res;
        }

    }
}
