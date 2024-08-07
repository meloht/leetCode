using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _473_MatchsticksToSquareAlg
    {
        public bool Makesquare(int[] matchsticks)
        {
            int sum = matchsticks.Sum();

            if (sum % 4 > 0)
                return false;

            Array.Sort(matchsticks, (x, y) => y.CompareTo(x));

            int[] edges = new int[4];

            return Dfs(0, matchsticks, edges, sum / 4);
        }

        private bool Dfs(int index, int[] matchsticks, int[] edges, int len)
        {
            if (index == matchsticks.Length)
                return true;

            for (int i = 0; i < edges.Length; i++)
            {
                edges[i] += matchsticks[index];
                if (edges[i] <= len && Dfs(index + 1, matchsticks, edges, len))
                {
                    return true;
                }
                edges[i] -= matchsticks[index];
            }
            return false;
        }
    }
}
