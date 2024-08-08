using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{

    public class _3131_FindTheIntegerAddedToArrayIAlg
    {
        public int AddedInteger(int[] nums1, int[] nums2)
        {

            int ans = nums2.Min()- nums1.Min();
          
            return ans;
        }
    }
}
