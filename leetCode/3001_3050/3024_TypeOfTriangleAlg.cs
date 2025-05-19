using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3024_TypeOfTriangleAlg
    {
        public string TriangleType(int[] nums)
        {
            Array.Sort(nums);
            if (nums[0] + nums[1] <= nums[2])
            {
                return "none";
            }
            int cnt = nums.Distinct().Count();
            if (cnt == 1)
                return "equilateral";
            else if (cnt == 2)
                return "isosceles";
            return "scalene";
        }
    }
}
