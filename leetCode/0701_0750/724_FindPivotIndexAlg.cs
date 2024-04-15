using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{

    public class _724_FindPivotIndexAlg
    {
        public int PivotIndex(int[] nums)
        {
            int[] arr = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i + 1] = arr[i] + nums[i];
            }
            int ans = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                int left = arr[i];
                int right = arr[nums.Length] - left - nums[i];
                if (left == right)
                {
                    ans = i;
                    break;
                }
            }

            return ans;
        }
    }
}
