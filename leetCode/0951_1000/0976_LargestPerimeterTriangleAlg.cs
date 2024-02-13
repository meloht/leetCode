using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0976_LargestPerimeterTriangleAlg
    {
        public int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);

            for (int j = nums.Length - 1; j >= 2; j--)
            {
                int a = nums[j];
                int b = nums[j - 1] + nums[j - 2];

                if (b > a)
                    return a + b;
            }

            return 0;
        }
    }
}
