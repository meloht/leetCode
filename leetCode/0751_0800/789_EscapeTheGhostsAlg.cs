using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _789_EscapeTheGhostsAlg
    {
        public bool EscapeGhosts(int[][] ghosts, int[] target)
        {

            int min = int.MaxValue;
            foreach (var ghost in ghosts)
            {
                min = Math.Min(min, Math.Abs(ghost[0] - target[0]) + Math.Abs(ghost[1] - target[1]));
            }

            int dis = Math.Abs(target[0]) + Math.Abs(target[1]);


            return dis < min;
        }
    }
}
