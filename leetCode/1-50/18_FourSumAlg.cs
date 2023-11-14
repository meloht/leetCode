using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class FourSumAlg
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> list = new List<IList<int>>();

            if (nums == null || nums.Length == 0)
                return list;
            int len = nums.Length;
            Array.Sort(nums);

            for (int i = 0; i < len - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target) break;
                if (nums[i] + nums[len - 1] + nums[len - 2] + nums[len - 3] < target) continue;


                for (int j = i + 1; j < len - 2; j++)
                {
                    if (j - i > 1 && nums[j] == nums[j - 1]) continue;
                    int left = j + 1;
                    int right = len - 1;

                    while (left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum == target)
                        {
                            list.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            while (left < right && nums[left] == nums[left + 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right - 1])
                            {
                                right--;
                            }
                            left++;
                            right--;
                        }
                        else if (sum < target)
                        {
                            while (left < right && nums[left] == nums[left + 1])
                            {
                                left++;
                            }
                            left++;
                        }
                        else if (sum > target)
                        {
                            while (left < right && nums[right] == nums[right - 1])
                            {
                                right--;
                            }
                            right--;
                        }
                    }
                }
            }

            return list;
        }
    }
}
