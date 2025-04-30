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
            int cnt = 0;
            Array.Sort(arr);
            foreach (var item in arr)
            {
                int nn = item * 2;
               
                if (dict.ContainsKey(nn))
                {
                    cnt++;

                    if (dict.ContainsKey(item))
                    {
                        dict[item]--;
                        if (dict[item] <= 0)
                        {
                            dict.Remove(item);
                        }
                    }
                    if (dict.ContainsKey(nn))
                    {
                        dict[nn]--;
                        if (dict[nn] <= 0)
                        {
                            dict.Remove(nn);
                        }
                    }

                }
            }
            if (cnt >= arr.Length / 2)
                return true;

            return false;
        }
    }
}
