using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.BiWeeklyConest.bi_132
{
    public class Alg_132_04
    {
        public int MaximumLength(int[] nums, int k)
        {
            Dictionary<int, int[]> fs = new Dictionary<int, int[]>();
            int[] max = new int[k + 2];
            foreach (var x in nums)
            {
                if (!fs.ContainsKey(x))
                {
                    fs.Add(x, new int[k + 1]);
                }
                int[] f = fs[x];
                for (int j = k; j >= 0; j--)
                {
                    f[j] = Math.Max(f[j], max[j]) + 1;
                    max[j + 1] = Math.Max(max[j + 1], f[j]);
                }
            }

            return max[k + 1];
        }
    }
}
