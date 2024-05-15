using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2589_MinimumTimeToCompleteAllTasksAlg
    {
        public int FindMinimumTime(int[][] tasks)
        {
            Array.Sort(tasks, (x, y) => x[1].CompareTo(y[1]));
            int n = tasks.Length;
            int[] run = new int[tasks[n - 1][1] + 1];
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                int start = tasks[i][0], end = tasks[i][1], duration = tasks[i][2];
                for (int j = start; j <= end; j++)
                {
                    duration -= run[j];
                }
                res += Math.Max(duration, 0);
                for (int j = end; j >= 0 && duration > 0; j--)
                {
                    if (run[j] == 0)
                    {
                        duration--;
                        run[j] = 1;
                    }
                }
            }
            return res;

        }
    }
}
