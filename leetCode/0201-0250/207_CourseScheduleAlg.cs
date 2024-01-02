using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _207_CourseScheduleAlg
    {
        HashSet<int> setOK = new HashSet<int>();
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (prerequisites.Length == 0)
                return true;

            int[][] dict = new int[numCourses][];

            foreach (int[] arr in prerequisites)
            {
                if (dict[arr[0]] == null)
                {
                    dict[arr[0]] = new int[] { };
                }
                dict[arr[0]] = dict[arr[0]].Append(arr[1]).ToArray();
            }

          
            for (int i = 0; i < numCourses; i++)
            {
                if (setOK.Contains(i))
                {
                    continue;
                }
                HashSet<int> set1 = new HashSet<int>();
                bool bl = Dfs(set1, dict, i);
                if (bl == false)
                    return false;

               
            }

            return true;
        }
        private bool Dfs(HashSet<int> set, int[][] dict, int n)
        {
            if (setOK.Contains(n))
                return true;
            if (set.Add(n) == false)
                return false;

            var next = dict[n];
            if (next == null || next.Length == 0)
                return true;

            foreach (var item in next)
            {
                bool bl = Dfs(set, dict, item);
                set.Remove(item);
                if (bl == false)
                    return false;
            }
            setOK.Add(n);
            return true;
        }
    }
}
