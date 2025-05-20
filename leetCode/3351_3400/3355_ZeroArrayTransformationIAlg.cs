using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3351_3400
{
    public class _3355_ZeroArrayTransformationIAlg
    {
        public bool IsZeroArray(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            int[] diff = new int[n + 1];

            foreach (var item in queries)
            {
                diff[item[0]]++;
                diff[item[1] + 1]--;
            }
            int[] counts = new int[n + 1];
            int current = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                current += diff[i];
                counts[i] = current;
            }


            for (int i = 0; i < n; i++)
            {
                if (counts[i] < nums[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
