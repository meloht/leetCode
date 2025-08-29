using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1090_LargestValuesFromLabelsAlg
    {
        public int LargestValsFromLabels(int[] values, int[] labels, int numWanted, int useLimit)
        {
            int[][] map = new int[values.Length][];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < values.Length; i++)
            {
                map[i] = [values[i], i];
                if (dict.ContainsKey(labels[i]))
                {
                    if (dict[labels[i]] < useLimit)
                    {
                        dict[labels[i]]++;
                    }

                }
                else
                {
                    dict.Add(labels[i], 1);
                }
            }

            Array.Sort(map, (x, y) => y[0] - x[0]);
            int ans = 0;
            for (int i = 0, j = numWanted; i < values.Length; i++)
            {
                if (j == 0)
                    break;
                int lbl = labels[map[i][1]];
                if (dict[lbl] > 0)
                {
                    ans += map[i][0];
                    dict[lbl]--;
                    j--;
                }
            }


            return ans;
        }
    }
}
