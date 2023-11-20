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
            List<Node> list = new List<Node>();
            foreach (var item in intervals)
            {
                Node node = new Node();
                node.begin = item[0];
                node.end = item[1];

                list.Add(node);
            }
            list = list.OrderBy(p => p.begin).ToList();
            List<Node> listRes = new List<Node>();
            Node nodePre = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                Node node = list[i];
                if (nodePre.end >= node.begin)
                {
                    nodePre.end = Math.Max(node.end, nodePre.end);
                    nodePre.begin = Math.Min(node.begin, nodePre.begin);
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
            int[][] arr = new int[listRes.Count][];
            for (int i = 0; i < listRes.Count; i++)
            {
                arr[i] = new int[] { listRes[i].begin, listRes[i].end };
            }

            return arr;
        }
        class Node
        {
            public int begin;
            public int end;
        }
    }
}
