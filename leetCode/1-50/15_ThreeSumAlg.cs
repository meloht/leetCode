using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class ThreeSumAlg
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> list = new List<IList<int>>();

            if (nums == null || nums.Length == 0)
                return list;
            int len = nums.Length;
            Array.Sort(nums);
            if (nums[0] > 0 || nums[len - 1] < 0)
                return list;

            for (int i = 0; i < len; i++)
            {
                if (nums[i] > 0)
                    break;
                if (i > 0 && nums[i - 1] == nums[i])
                {
                    continue;
                }
                int sencond = i + 1;
                int third = len - 1;

                while (sencond < third)
                {
                    int sum = nums[i] + nums[sencond] + nums[third];
                    if (sum == 0)
                    {
                        list.Add(new List<int> { nums[i], nums[sencond], nums[third] });
                        while (sencond < third && nums[sencond] == nums[sencond + 1])
                        {
                            sencond++;
                        }
                        while (sencond < third && nums[third] == nums[third - 1])
                        {
                            third--;
                        }
                        sencond++;
                        third--;
                    }
                    else if (sum < 0)
                    {
                        while (sencond < third && nums[sencond] == nums[sencond + 1])
                        {
                            sencond++;
                        }
                        sencond++;
                    }
                    else if (sum > 0)
                    {
                        while (sencond < third && nums[third] == nums[third - 1])
                        {
                            third--;
                        }
                        third--;
                    }
                }
            }
            return list;
        }
    }
}
