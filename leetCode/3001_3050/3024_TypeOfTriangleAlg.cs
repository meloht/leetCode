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

            if (nums[0] == nums[2])
                return "equilateral";
            else if (nums[0] == nums[1] || nums[1] == nums[2])
                return "isosceles";
           

            return "scalene";
        }
    }
}
