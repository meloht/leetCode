using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _454_4SumIIAlg
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            Dictionary<long, int> dict1 = GetDict(nums1, nums2);
            Dictionary<long, int> dict2 = GetDict(nums3, nums4);
            int ans = 0;
            foreach (var item in dict1)
            {
                long val = -item.Key;
                if (dict2.ContainsKey(val))
                {
                    ans += (item.Value * dict2[val]);
                }
            }


            return ans;
        }

        private Dictionary<long, int> GetDict(int[] nums1, int[] nums2)
        {
            Dictionary<long, int> dict = new Dictionary<long, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    long val = nums1[i] + nums2[j];
                    if (dict.ContainsKey(val))
                    {
                        dict[val]++;
                    }
                    else
                    {
                        dict.Add(val, 1);
                    }
                }
            }
            return dict;
        }
    }
}
