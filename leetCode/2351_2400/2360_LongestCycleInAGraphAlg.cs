using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2351_2400
{
    public class _2360_LongestCycleInAGraphAlg
    {
        public int LongestCycle1(int[] edges)
        {
            int n = edges.Length;
            int maxCycle = -1;
            bool[] visited = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    Dictionary<int, int> stepMap = new Dictionary<int, int>();
                    int current = i;
                    int step = 0;
                    while (current != -1)
                    {
                        if (stepMap.ContainsKey(current))
                        {
                            int cycleLength = step - stepMap[current];
                            if (cycleLength > maxCycle)
                            {
                                maxCycle = cycleLength;
                            }
                            break;
                        }
                        if (visited[current])
                        {
                            break;
                        }
                        visited[current] = true;
                        stepMap[current] = step;
                        step++;
                        current = edges[current];
                    }
                }
            }
            return maxCycle;
        }

        public int LongestCycle(int[] edges)
        {
            int n = edges.Length;
            int[] label = new int[n];
            int current_label = 0, ans = -1;
            for (int i = 0; i < n; ++i)
            {
                if (label[i] != 0)
                {
                    continue;
                }
                int pos = i, start_label = current_label;
                while (pos != -1)
                {
                    ++current_label;
                    // 如果遇到了已经遍历过的节点
                    if (label[pos] != 0)
                    {
                        // 如果该节点是这一次 i 循环中遍历的，说明找到了新的环，更新答案
                        if (label[pos] > start_label)
                        {
                            ans = Math.Max(ans, current_label - label[pos]);
                        }
                        break;
                    }
                    label[pos] = current_label;
                    pos = edges[pos];
                }
            }
            return ans;
        }


    }
}
