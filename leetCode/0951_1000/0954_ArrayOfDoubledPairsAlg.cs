using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0954_ArrayOfDoubledPairsAlg
    {
        public bool CanReorderDoubled(int[] arr)
        {
            Dictionary<int, int> dict = [];
            foreach (int i in arr)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            if (dict.ContainsKey(0) && dict[0] % 2 != 0)
            {
                return false;
            }

            var list = dict.Keys.ToArray();
            Array.Sort(list, (x, y) => Math.Abs(x) - Math.Abs(y));

            foreach (var item in list)
            {

                if (dict.ContainsKey(item * 2))
                {
                    if (dict[item * 2] < dict[item])
                    {
                        return false;
                    }
                    dict[item * 2] -= dict[item];

                }
                else
                {
                    if (dict[item] > 0)
                        return false;
                }
            }

            return true;
        }
    }
}
