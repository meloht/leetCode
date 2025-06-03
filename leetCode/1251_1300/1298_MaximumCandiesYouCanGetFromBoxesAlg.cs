using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1251_1300
{
    public class _1298_MaximumCandiesYouCanGetFromBoxesAlg
    {
        public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes)
        {
            int n = status.Length;
            bool[] visited = new bool[n];
            int[] keySey = new int[n];
            bool[] noUser = new bool[n];
            Queue<int> queue = new Queue<int>();
            foreach (var item in initialBoxes)
            {
                queue.Enqueue(item);
                visited[item] = true;

            }
            int ans = 0;

            while (queue.Count > 0)
            {
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    int idx = queue.Dequeue();

                    var arr = keys[idx];
                    foreach (var item in arr)
                    {
                        if (idx == item)
                            continue;
                        keySey[item]++;
                        if (noUser[item])
                        {
                            ans += candies[item];
                            noUser[item] = false;
                        }
                    }

                    if (status[idx] == 1)
                    {
                        ans += candies[idx];

                    }
                    else
                    {
                        if (keySey[idx] > 0)
                        {
                            ans += candies[idx];
                        }
                        else
                        {
                            noUser[idx] = true;
                        }

                    }
                    var boxs = containedBoxes[idx];
                    foreach (var item in boxs)
                    {
                        if (visited[item] == false)
                        {
                            queue.Enqueue(item);
                            visited[item] = true;
                        }
                    }
                }
            }

            return ans;
        }
    }
}
