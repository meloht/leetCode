using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _401_BinaryWatchAlg
    {
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            if (turnedOn > 8)
            {
                List<string> res = new List<string>();
                return res;
            }
            HashSet<string> set = new HashSet<string>();
            int[] h = [8, 4, 2, 1];
            int[] m = [32, 16, 8, 4, 2, 1];
            Dfs(h, m, 0, 0, 0, 0, turnedOn, set);
            return set.ToList();
        }

        private void Dfs(int[] h, int[] m, int i, int j, int numH, int numM, int count, HashSet<string> res)
        {
            if (i >= h.Length || j >= m.Length)
            {
                return;
            }

            if (numH > 12 || numM > 59)
            {
                return;
            }

            if (count == 0)
            {
                res.Add($"{numH}:{numM.ToString().PadLeft(2, '0')}");
                return;
            }
            int n1 = numH + h[i];
            Dfs(h, m, i + 1, j, numH, numM, count, res);
            Dfs(h, m, i + 1, j, n1, numM, count - 1, res);
          

            int n2 = numM + m[j];
            Dfs(h, m, i, j + 1, numH, numM, count, res);
            Dfs(h, m, i, j + 1, numH, n2, count - 1, res);

            Dfs(h, m, i + 1, j + 1, numH, numM, count, res);
            Dfs(h, m, i + 1, j + 1, n1, n2, count - 2, res);
           
        }
    }
}
