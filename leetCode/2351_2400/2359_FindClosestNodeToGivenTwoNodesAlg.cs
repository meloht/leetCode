using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2351_2400
{
    public class _2359_FindClosestNodeToGivenTwoNodesAlg
    {
        public int ClosestMeetingNode(int[] edges, int node1, int node2)
        {
            var dict1 = GetList(edges, node1);
            bool[] visited = new bool[edges.Length];

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(node2);
            visited[node2] = true;

            int dis = 0;
            int disMin = int.MaxValue;
            int ans = int.MaxValue;
            while (queue.Count > 0)
            {
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    int p = queue.Dequeue();

                    if (dict1[p] > -1)
                    {
                        int max = Math.Max(dis, dict1[p]);
                        if (max <= disMin)
                        {
                            if (max == disMin)
                            {
                                ans = Math.Min(ans, p);
                            }
                            else
                            {
                                ans = p;
                            }

                            disMin = max;
                        }
                    }

                    int next = edges[p];
                    if (next > -1 && !visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);

                    }
                }
                dis++;
            }
            if (ans != int.MaxValue)
                return ans;

            return -1;
        }

        private int[] GetList(int[] edges, int node)
        {
            bool[] visited = new bool[edges.Length];

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(node);
            visited[node] = true;

            int[] dict = new int[edges.Length];
            Array.Fill(dict, -1);
            dict[node] = 0;
            int dis = 1;
            while (queue.Count > 0)
            {
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    int p = queue.Dequeue();
                    int next = edges[p];

                    if (next > -1 && !visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);

                        dict[next] = dis;
                    }
                }
                dis++;
            }
            return dict;
        }

    }
}
