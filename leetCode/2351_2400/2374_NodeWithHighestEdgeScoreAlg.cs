using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2351_2400
{
    public class _2374_NodeWithHighestEdgeScoreAlg
    {
        public int EdgeScore(int[] edges)
        {
            long[] dict = new long[edges.Length];

            int ans = 0;
            for (int i = 0; i < edges.Length; i++)
            {
                int node = edges[i];
                dict[node] += i;
                if (dict[ans] < dict[node] || (dict[node] == dict[ans] && node < ans))
                {
                    ans = node;
                }
            }


            return ans;
        }
    }
}
