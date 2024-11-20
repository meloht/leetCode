using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _621_TaskSchedulerAlg
    {
        public int LeastInterval(char[] tasks, int n)
        {
            int[] arr = new int[26];

            int maxExec = 0;
            for (int i = 0; i < tasks.Length; i++)
            {
                int idx = tasks[i] - 'A';
                arr[idx]++;
                maxExec = Math.Max(maxExec, arr[idx]);
            }
            int maxCount = 0;
            foreach (var item in arr)
            {
                if (item == maxExec)
                {
                    maxCount++;
                }
            }

            return Math.Max((maxExec - 1) * (n + 1) + maxCount, tasks.Length);
        }
    }
}
