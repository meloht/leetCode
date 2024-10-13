using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1851_1900
{
    public class _1884_EggDropWith2EggsAndNFloorsAlg
    {
        public int TwoEggDrop(int n)
        {
            int[] f = new int[1001];
            for (int i = 1; i < f.Length; i++)
            {
                f[i] = int.MaxValue;
                for (int j = 1; j <= i; j++)
                {
                    f[i] = Math.Min(f[i], Math.Max(j, f[i - j] + 1));
                }
            }


            return f[n];
        }
    }
}
