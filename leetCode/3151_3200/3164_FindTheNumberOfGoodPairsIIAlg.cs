using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3164_FindTheNumberOfGoodPairsIIAlg
    {
        public long NumberOfPairs(int[] nums1, int[] nums2, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            int max1 = 0;
            foreach (var item in nums1)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
                max1 = Math.Max(max1, item);
            }

            foreach (var item in nums2)
            {
                if (dict2.ContainsKey(item))
                {
                    dict2[item]++;
                }
                else
                {
                    dict2.Add(item, 1);
                }
            }

            long res = 0;
            foreach (var item in dict2.Keys)
            {
                for (int i = item * k; i <= max1; i += item * k)
                {
                    if (dict.ContainsKey(i)) 
                    {
                        res += 1L * dict[i] * dict2[item];
                    }
                }
            }

            return res;
        }
    }
}
