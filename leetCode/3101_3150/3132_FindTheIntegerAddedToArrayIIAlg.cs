using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3132_FindTheIntegerAddedToArrayIIAlg
    {
        public int MinimumAddedInteger(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            int[] idx0 = [2, 1, 0];
            foreach (int i in idx0)
            {
                int idx1 = i + 1;
                int idx2 = 1;
                while (idx1 < nums1.Length && idx2 < nums2.Length)
                {
                    if (nums1[idx1] - nums2[idx2] == nums1[i] - nums2[0])
                    {
                        idx2++;
                    }
                    idx1++;
                }
                if (idx2 == nums2.Length)
                {
                    return nums2[0] - nums1[i];
                }
            }

            return 0;
        }
    }
}
