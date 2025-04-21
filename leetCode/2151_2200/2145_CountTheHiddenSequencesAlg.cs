using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2151_2200
{
    public class _2145_CountTheHiddenSequencesAlg
    {
        public int NumberOfArrays(int[] differences, int lower, int upper)
        {
            long s = 0;
            long mins = 0;
            long maxs = 0;
            foreach (var item in differences)
            {
                s += item;
                mins = Math.Min(s, mins);
                maxs = Math.Max(s, maxs);
            }
            return (int)Math.Max(upper - lower - maxs + mins + 1, 0);
        }
    }
}
