using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2951_3000
{
    public class _2974_MinimumNumberGameAlg
    {
        public int[] NumberGame(int[] nums)
        {
            int[] arr = new int[nums.Length];
            Array.Sort(nums);
            int j = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                int n1 = nums[i];
                int n2 = nums[i + 1];

                arr[j++] = n2;
                arr[j++] = n1;
            }
            return arr;
        }
    }
}
