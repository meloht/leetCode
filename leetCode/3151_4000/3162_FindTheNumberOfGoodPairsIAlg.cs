using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_4000
{
    public class _3162_FindTheNumberOfGoodPairsIAlg
    {
        public int NumberOfPairs(int[] nums1, int[] nums2, int k)
        {

            int ans = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                foreach (var item in nums2)
                {
                    if (nums1[i] % (item * k) == 0) 
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}
