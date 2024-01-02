using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0201_0250
{
    public class _207_CourseScheduleAlg
    {
        HashSet<int> setOK = new HashSet<int>();
        public bool CanFinish1(int numCourses, int[][] prerequisites)
        {
            if (prerequisites.Length == 0)
                return true;

            List<List<int>> dict = new List<List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                dict.Add(new List<int>());
            }
            foreach (int[] arr in prerequisites)
            {
                dict[arr[0]].Add(arr[1]);
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
        private bool Dfs(HashSet<int> set, List<List<int>> dict, int n)
        {
            if (setOK.Contains(n))
                return true;
            if (set.Add(n) == false)
                return false;

            var next = dict[n];
            if (next.Count == 0)
            {
                setOK.Add(n);
                return true;
            }

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

        bool valid = true;
        public bool CanFinish2(int numCourses, int[][] prerequisites)
        {
            List<List<int>> edges = new List<List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                edges.Add(new List<int>());
            }
            int[] visited = new int[numCourses];
            foreach (var item in prerequisites)
            {
                edges[item[1]].Add(item[0]);
            }

            for (int i = 0; i < numCourses && valid; i++)
            {
                if (visited[i] == 0)
                {
                    Dfs(i, visited, edges);
                }
            }
            return valid;
        }

        public void Dfs(int u, int[] visited, List<List<int>> edges)
        {
            visited[u] = 1;
            foreach (int v in edges[u])
            {
                if (visited[v] == 0)
                {
                    Dfs(v, visited, edges);
                    if (!valid)
                    {
                        return;
                    }
                }
                else if (visited[v] == 1)
                {
                    valid = false;
                    return;
                }
            }
            visited[u] = 2;
        }



        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            List<List<int>> edges = new List<List<int>>();
            int[] inDeg = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                edges.Add(new List<int>());
            }
            foreach (var item in prerequisites)
            {
                edges[item[1]].Add(item[0]);
                inDeg[item[0]]++;
            }
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (inDeg[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }
            int visited = 0;
            while (queue.Count > 0)
            {
                visited++;
                int u = queue.Dequeue();
                var list = edges[u];
                foreach (int item in list)
                {
                    inDeg[item]--;
                    if (inDeg[item] == 0)
                    {
                        queue.Enqueue(item);
                    }
                }

            }

            return visited == numCourses;
        }

    }
}
