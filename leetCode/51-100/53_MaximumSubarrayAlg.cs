using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _53_MaximumSubarrayAlg
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int max = GetMaxForList(nums);

            List<int> list = GetMergePlusMinus(nums);
            int len = list.Count;
            if (len == 1)
            {
                max = Math.Max(list[0], max);
                return max;
            }
            if (len == 2)
            {
                max = Math.Max(max, list.Max());
                return max;
            }

            while (list.Count > 1 && list[0] <= 0)
            {
                list.RemoveAt(0);
            }
            while (list.Count > 1 && list[list.Count - 1] <= 0)
            {
                list.RemoveAt(list.Count - 1);
            }
            int numMax1 = GetMergeList(list);
            return Math.Max(max, numMax1);
           
        }
        private int GetMaxForList(int[] nums)
        {
            int max = int.MinValue;
            int sum = 0;
            foreach (int num in nums)
            {
                max = Math.Max(max, num);
                sum += num;
            }
            max = Math.Max(max, sum);
            return max;
        }

        private int GetMergeList(List<int> res)
        {
            int len = res.Count;
            int total = 0;
            int max = int.MinValue;
            int i = 0;
            while (i < len)
            {
                int plusNum = res[i];
                total += plusNum;
                max = Math.Max(total, max);

                int indexNext = i + 1;
                if (indexNext < len)
                {
                    int nextNum = res[indexNext];

                    int num = total + nextNum;
                    if (num > 0)
                    {
                        total = num;
                    }
                    else
                    {
                        total = 0;
                    }
                }
                i += 2;
            }
            return max;
        }
      
        private List<int> GetMergePlusMinus(int[] nums)
        {
            int len = nums.Length;
            int num = 0;
            List<int> list = new List<int>();

            int index = 0;
            int nextIndex = 0;
            int nextNum = 0;
            int sum = 0;

            while (index < len)
            {
                num = nums[index];
                sum += num;
                nextIndex = index + 1;
                if (nextIndex < len)
                {
                    nextNum = nums[nextIndex];
                    if (nextNum >= 0)
                    {
                        if (num < 0)
                        {
                            list.Add(sum);
                            sum = 0;
                        }

                    }
                    else if (nextNum < 0)
                    {
                        if (num >= 0)
                        {
                            list.Add(sum);
                            sum = 0;
                        }
                    }
                }
                else
                {
                    list.Add(sum);
                }
                index++;
            }
            return list;
        }

    }
}
