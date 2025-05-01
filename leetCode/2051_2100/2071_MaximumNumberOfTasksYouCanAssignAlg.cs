using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2051_2100
{
    public class _2071_MaximumNumberOfTasksYouCanAssignAlg
    {
        public int MaxTaskAssign1(int[] tasks, int[] workers, int pills, int strength)
        {
            Array.Sort(tasks);
            Array.Sort(workers);

            int left = 0;
            int mn = Math.Min(tasks.Length, workers.Length);
            int[] validTasks = new int[mn];
            int right = mn + 1;

            while (left + 1 < right)
            {
                int mid = (left + right) >> 1;
                if (CheckArr(tasks, workers, pills, strength, mid, validTasks))
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }

        public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
        {
            Array.Sort(tasks);
            Array.Sort(workers);

            int left = 1;
            int mn = Math.Min(tasks.Length, workers.Length);

            int[] validTasks = new int[mn];
            int right = mn;
            int ans = 0;
            while (left <= right)
            {
                int mid = (left + right) >> 1;
                if (CheckArr(tasks, workers, pills, strength, mid, validTasks))
                {
                    ans = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return ans;
        }




        public bool CheckArr(int[] task, int[] workers, int pills, int strength, int k, int[] validTasks)
        {
            int head = 0;
            int tail = 0;
            int i = 0;
            for (int j = workers.Length - k; j < workers.Length; j++)
            {
                int w = workers[j];
                while (i < k && task[i] <= w + strength)
                {
                    validTasks[tail++] = task[i];
                    i++;
                }
                if (head == tail)
                {
                    return false;
                }
                if (w >= validTasks[head])
                {
                    head++;
                    continue;
                }
                if (pills == 0)
                    return false;

                pills--;
                tail--;
            }

            return true;
        }

    }
}
