using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _918_MaximumSumCircularSubarrayAlg
    {
        public int MaxSubarraySumCircular(int[] nums)
        {
            int n = nums.Length;
            int max = int.MinValue;
            int k = nums.Length * 2;
            int i = 0;
            int sum = 0;
            Queue<int> queue = new Queue<int>();
            while (k > 0)
            {
                int temp = sum;
                int num = nums[i];
                sum += num;
                queue.Enqueue(num);
                if (sum >= temp)
                {
                    max = Math.Max(max, sum);
                }
                else
                {
                    while (queue.Count > 0 && sum < temp)
                    {
                        sum -= queue.Dequeue();
                    }
                }
                i = (i + 1) % n;
                k--;
            }
            return max;
        }
        private int GetNax(int begin, int[] nums)
        {
            int n = nums.Length;
            int k = nums.Length;
            int i = begin;
            int pre = 0;
            int max = nums[begin];
            while (k > 0)
            {
                pre = Math.Max(pre + nums[i], nums[i]);
                max = Math.Max(max, pre);
                i = (i + 1) % n;
                k--;
            }
            return max;
        }

    }
}
