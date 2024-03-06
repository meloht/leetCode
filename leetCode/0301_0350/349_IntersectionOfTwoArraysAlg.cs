using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _349_IntersectionOfTwoArraysAlg
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> result = new HashSet<int>();
            HashSet<int> set=new HashSet<int>(nums2);
            foreach (var item in nums1)
            {
                if (set.Contains(item)) 
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}
