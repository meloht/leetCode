using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2766_RelocateMarblesAlg
    {
        public IList<int> RelocateMarbles(int[] nums, int[] moveFrom, int[] moveTo)
        {
            HashSet<int> set = new HashSet<int>(nums);
            for (int i = 0; i < moveFrom.Length; i++)
            {
                int n = moveFrom[i];
                if (!set.Contains(n)) 
                {
                    continue;
                }
                int to = moveTo[i];
                set.Remove(n);
                set.Add(to);
            }
            var list = set.ToList();
            list.Sort();
            return list;
        }
    }
}
