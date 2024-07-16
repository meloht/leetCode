using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2951_3000
{
    public class _2956_FindCommonElementsBetweenTwoArraysAlg
    {
        public int[] FindIntersectionValues(int[] nums1, int[] nums2)
        {
            var dict1 = nums1.ToHashSet();
            var dict2 = nums2.ToHashSet();

            int ans1 = 0;
            int ans2 = 0;

            foreach (var item in nums1)
            {
                if (dict2.Contains(item)) 
                {
                    ans1++;
                }
            }
            foreach (var item in nums2)
            {
                if (dict1.Contains(item))
                {
                    ans2++;
                }
            }

            return [ans1, ans2];
        }
    }
}
