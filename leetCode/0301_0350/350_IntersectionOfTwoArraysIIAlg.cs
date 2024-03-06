using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _350_IntersectionOfTwoArraysIIAlg
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
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

            }
            List<int> result=new List<int>();
            foreach (var item in nums2)
            {
                if (dict.ContainsKey(item) && dict[item] > 0)
                {
                    result.Add(item);
                    dict[item]--;
                }
            }
            return result.ToArray();
        }
    }
}
