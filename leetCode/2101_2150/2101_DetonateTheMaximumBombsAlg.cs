using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2101_DetonateTheMaximumBombsAlg
    {
        public int MaximumDetonation(int[][] bombs)
        {
            int n = bombs.Length;
            Dictionary<int[], List<int[]>> dictDis = new Dictionary<int[], List<int[]>>();

            for (int i = 0; i < n; i++)
            {
                int[] p1 = bombs[i];
                long x1 = p1[0];
                long y1 = p1[1];
                long r1 = p1[2];
                long rr = r1 * r1;
                dictDis.Add(p1, new List<int[]>());

                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;
                    int[] p2 = bombs[j];
                    long x2 = p2[0];
                    long y2 = p2[1];
                    long r2 = p2[2];
                  
                    long dis = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
                    if (dis <= rr)
                    {
                        dictDis[p1].Add(p2);
                    }
                }
            }

            int ans = 0;
            HashSet<int[]> set = new HashSet<int[]>();
            for (int i = 0; i < n; i++)
            {
                int cnt = 1;
                Queue<int[]> queue = new Queue<int[]>();
                set.Clear();
                queue.Enqueue(bombs[i]);
                set.Add(bombs[i]);

                while (queue.Count > 0)
                {
                    int count = queue.Count;

                    for (int j = 0; j < count; j++)
                    {
                        var p = queue.Dequeue();
                        if (dictDis[p].Count > 0)
                        {
                            var ls = dictDis[p];
                            foreach (var item in ls)
                            {
                                if (set.Contains(item))
                                    continue;
                                cnt++;
                                set.Add(item);
                                queue.Enqueue(item);
                            }
                        }
                    }
                }

                ans = Math.Max(ans, cnt);

            }

            return ans;
        }
    }
}
