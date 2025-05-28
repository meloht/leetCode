using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3351_3400
{
    public class _3372_MaximizeTheNumberOfTargetNodesAfterConnectingTreesIAlg
    {
        public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
        {
            int n = edges1.Length + 1;
            int[] ans = new int[n];
            List<int>[] arr1 = GetAdjArr(edges1);
            List<int>[] arr2 = GetAdjArr(edges2);
            int count = GetMax(arr2, k);
            for (int i = 0; i < n; i++)
            {
                ans[i] = GetMax(arr1, i, k) + count;
            }

            return ans;
        }

        private int GetMax(List<int>[] arr, int k)
        {
            int ans = 0;
            if (k == 0)
                return ans;
            for (int i = 0; i < arr.Length; i++)
            {
                ans = Math.Max(ans, GetMax(arr, i, k - 1));
            }
            return ans;
        }

        private List<int>[] GetAdjArr(int[][] edges)
        {
            List<int>[] arr = new List<int>[edges.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new List<int>();
            }

            foreach (var item in edges)
            {
                arr[item[0]].Add(item[1]);
                arr[item[1]].Add(item[0]);
            }
            return arr;
        }

        private int GetMax(List<int>[] arr, int idx, int k)
        {
            int num = 1;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(idx);
            bool[] visited = new bool[arr.Length];
            visited[idx] = true;
            while (queue.Count > 0 && k > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    int p = queue.Dequeue();

                    var next = arr[p];
                    foreach (var item in next)
                    {
                        if (!visited[item])
                        {
                            queue.Enqueue(item);
                            visited[item] = true;
                            num++;
                        }
                    }

                }
                k--;

            }
            return num;
        }


    }
}
