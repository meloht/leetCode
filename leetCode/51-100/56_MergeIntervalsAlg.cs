using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _56_MergeIntervalsAlg
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 1)
            {
                return intervals;
            }
            var list = intervals.OrderBy(p => p[0]).ToList();

            List<int[]> listRes = new List<int[]>();
            var nodePre = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                var node = list[i];
                if (nodePre[1] >= node[0])
                {
                    nodePre[1] = Math.Max(node[1], nodePre[1]);
                    nodePre[0] = Math.Min(node[0], nodePre[0]);
                    if (i == list.Count - 1)
                    {
                        listRes.Add(nodePre);
                    }
                }
                else
                {
                    listRes.Add(nodePre);
                    nodePre = list[i];
                    if (i == list.Count - 1)
                    {
                        listRes.Add(list[i]);
                    }
                }

            }

            return listRes.ToArray();
        }
 
    }
}
