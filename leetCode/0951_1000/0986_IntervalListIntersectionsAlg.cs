using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0986_IntervalListIntersectionsAlg
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            List<int[]> ans = new List<int[]>();

            for (int i = 0, j = 0; i < firstList.Length && j < secondList.Length;)
            {
                int[] f1 = firstList[i];
                int[] f2 = secondList[j];
                if (f1[1] >= f2[0] && f1[0] <= f2[1])
                {
                    ans.Add([Math.Max(f1[0], f2[0]), Math.Min(f1[1], f2[1])]);
                    if (f1[1] > f2[1])
                    {
                        j++;
                    }
                    else if (f2[1] > f1[1])
                    {
                        i++;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
                else if (f1[0] > f2[1])
                {
                    j++;
                }
                else if (f2[0] > f1[1])
                {
                    i++;
                }
            }

            return ans.ToArray();
        }
    }
}
