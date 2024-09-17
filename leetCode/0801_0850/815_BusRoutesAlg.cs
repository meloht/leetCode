using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _815_BusRoutesAlg
    {
        public int NumBusesToDestination(int[][] routes, int source, int target)
        {
            // 记录经过车站 x 的公交车编号
            Dictionary<int, List<int>> stopToBuses = new Dictionary<int, List<int>>();
            for (int i = 0; i < routes.Length; i++)
            {
                foreach (var x in routes[i])
                {
                    if (stopToBuses.ContainsKey(x))
                    {
                        stopToBuses[x].Add(i);
                    }
                    else
                    {
                        List<int> list = new List<int>();
                        list.Add(i);
                        stopToBuses.Add(x, list);
                    }
                }
            }

            // 小优化：如果没有公交车经过起点或终点，直接返回
            if (!stopToBuses.ContainsKey(source) || !stopToBuses.ContainsKey(target))
            {
                // 注意原地 TP 的情况
                return source != target ? -1 : 0;
            }

            // BFS
            Dictionary<int, int> dis = new Dictionary<int, int>();
            dis.Add(source, 0);
            Queue<int> q = new Queue<int>();
            q.Enqueue(source);
            while (q.Count>0)
            {
                int x = q.Dequeue(); // 当前在车站 x
                int disX = dis[x];
                foreach (int i in stopToBuses[x])
                { // 遍历所有经过车站 x 的公交车 i
                    if (routes[i] != null)
                    {
                        foreach (int y in routes[i])
                        { // 遍历公交车 i 的路线
                            if (!dis.ContainsKey(y))
                            { // 没有访问过车站 y
                                dis.Add(y, disX + 1); // 从 x 站上车然后在 y 站下车
                                q.Enqueue(y);
                            }
                        }
                        routes[i] = null; // 标记 routes[i] 遍历过
                    }
                }
            }
            if(dis.ContainsKey(target))
                return dis[target];
            return -1;


        }
    }
}
