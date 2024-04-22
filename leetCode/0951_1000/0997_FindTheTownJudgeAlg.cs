using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0997_FindTheTownJudgeAlg
    {
        public int FindJudge(int n, int[][] trust)
        {

            Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();
            foreach (var item in trust)
            {
                if (dict.ContainsKey(item[0]))
                {
                    dict[item[0]].Add(item[1]);
                }
                else
                {
                    HashSet<int> sett = new HashSet<int>();
                    sett.Add(item[1]);
                    dict.Add(item[0], sett);
                }
            }

            if (dict.Count != n - 1)
                return -1;
            int ans = -1;
            for (int i = 1; i <= n; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    ans = i;
                    break;
                }
            }
            if (ans == -1)
                return -1;
            foreach (var item in dict)
            {
                if (!item.Value.Contains(ans))
                    return -1;
            }
            return ans;
        }

        public int FindJudge1(int n, int[][] trust)
        {
            int[] inDegrees = new int[n + 1];
            int[] outDegrees = new int[n + 1];
            foreach (int[] edge in trust)
            {
                int x = edge[0], y = edge[1];
                ++inDegrees[y];
                ++outDegrees[x];
            }
            for (int i = 1; i <= n; ++i)
            {
                if (inDegrees[i] == n - 1 && outDegrees[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
