using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3186_MaximumTotalDamageWithSpellCastingAlg
    {
        public long MaximumTotalDamage(int[] power)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in power)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            int n = dict.Count;

            int[] a = new int[n];

            int k = 0;
            foreach (var item in dict.Keys)
            {
                a[k++] = item;
            }

            Array.Sort(a);

            long[] f = new long[n + 1];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                int x = a[i];
                while (a[j] < x - 2)
                {
                    j++;
                }
                f[i + 1] = Math.Max(f[i], f[j] + (long)x * dict[x]);
            }
            return f[n];


        }
    }
}
