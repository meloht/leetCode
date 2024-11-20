using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3244_ShortestDistanceAfterRoadAdditionQueriesIIAlg
    {
        public int[] ShortestDistanceAfterQueries(int n, int[][] queries) 
        {
            int[] nxt = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                nxt[i] = i + 1;
            }

            int[] ans = new int[queries.Length];
            int cnt = n - 1;
            for (int qi = 0; qi < queries.Length; qi++)
            {
                int i = queries[qi][0];
                int r = queries[qi][1];
                while (nxt[i] < r)
                {
                    cnt--;
                    int tmp = nxt[i];
                    nxt[i] = r;
                    i = tmp;
                }
                ans[qi] = cnt;
            }
            return ans;

        }
    }
}
