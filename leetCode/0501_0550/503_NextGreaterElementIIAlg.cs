using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _503_NextGreaterElementIIAlg
    {
        public int[] NextGreaterElements(int[] nums)
        {
            int[] res = new int[nums.Length];
            Array.Fill(res, -1);

            Stack<int> stack = new Stack<int>();
            int max = nums.Max();
            int maxIdx = Array.IndexOf(nums, max);
            for (int i = 0; i < nums.Length; i++)
            {
                while (stack.Count > 0 && nums[stack.Peek()] < nums[i])
                {
                    var item = stack.Pop();
                    res[item] = nums[i];
                }
                stack.Push(i);
            }
            if (stack.Count == 0 || (stack.Count == 1 && nums[stack.Peek()] == max))
            {
                return res;
            }
            for (int i = 0; i <= maxIdx; i++)
            {
                while (stack.Count > 0 && nums[stack.Peek()] < nums[i])
                {
                    var item = stack.Pop();
                    res[item] = nums[i];
                }
                if (stack.Count == 0 || (stack.Count == 1 && nums[stack.Peek()] == max))
                {
                    return res;
                }
            }

            return res;
        }
    }
}
