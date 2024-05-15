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
            Array.Sort(tasks, (x, y) => x[0].CompareTo(y[0]));

            return 0;
        }
    }
}
