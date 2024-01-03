using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _740_DeleteAndEarnAlg
    {
        public int DeleteAndEarn1(int[] nums)
        {
            int maxVal = 0;
            foreach (int val in nums)
            {
                maxVal = Math.Max(maxVal, val);
            }
            int[] sum = new int[maxVal + 1];
            foreach (int val in nums)
            {
                sum[val] += val;
            }
            return Rob(sum);

        }

        private int Rob(int[] nums)
        {
            int size = nums.Length;
            int first = nums[0], second = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < size; i++)
            {
                int temp = second;
                second = Math.Max(first + nums[i], second);
                first = temp;
            }
            return second;
        }


        public int DeleteAndEarn(int[] nums)
        {
            int n = nums.Length;
            int ans = 0;
            Array.Sort(nums);
            IList<int> sum = new List<int>();
            sum.Add(nums[0]);
            int size = 1;
            for (int i = 1; i < n; ++i)
            {
                int val = nums[i];
                if (val == nums[i - 1])
                {
                    sum[size - 1] += val;
                }
                else if (val == nums[i - 1] + 1)
                {
                    sum.Add(val);
                    ++size;
                }
                else
                {
                    ans += Rob(sum);
                    sum.Clear();
                    sum.Add(val);
                    size = 1;
                }
            }
            ans += Rob(sum);
            return ans;
        }

        private int Rob(IList<int> nums)
        {
            int size = nums.Count;
            if (size == 1)
            {
                return nums[0];
            }
            int first = nums[0], second = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < size; i++)
            {
                int temp = second;
                second = Math.Max(first + nums[i], second);
                first = temp;
            }
            return second;
        }

    }
}
