using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1501_1550
{
    public class _1547_MinimumCostToCutAStickAlg
    {
        public int MinCost(int n, int[] cuts)
        {
            Array.Sort(cuts);
            int m = cuts.Length + 2;
            int[] newCuts = new int[m];
            Array.Copy(cuts, 0, newCuts, 1, m - 2);
            newCuts[m - 1] = n;

            int[,] f = new int[m,m];
            for (int i = m - 3; i >= 0; i--)
            {
                for (int j = i + 2; j < m; j++)
                {
                    int res = int.MaxValue;
                    for (int k = i + 1; k < j; k++)
                    {
                        res = Math.Min(res, f[i,k] + f[k,j]);
                    }
                    f[i, j] = res + newCuts[j] - newCuts[i];
                }
            }
            return f[0,m - 1];


        }

    }
}
