using leetCode.InterviewQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _462_MinimumMovesToEqualArrayElementsIIAlg
    {
        public int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            int avg = nums[nums.Length / 2]; 
            int ans = 0;
            foreach (var item in nums)
            {
                ans += Math.Abs(item - avg);
            }
            return ans;
        }
    }
}
