using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0962_MaximumWidthRampAlg
    {
        public int MaxWidthRamp1(int[] nums)
        {
            int n = nums.Length;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
            Array.Sort(arr, (x, y) => { if (nums[x] != nums[y]) return nums[x] - nums[y]; else return x - y; });
            int ans = 0;
            int min = n;

            foreach (var item in arr)
            {
                ans = Math.Max(ans, item - min);
                min = Math.Min(min, item);
            }
            return ans;
        }

        public int MaxWidthRamp(int[] nums)
        {
            int n = nums.Length;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(i);
                }
                else if (nums[i] < nums[stack.Peek()])
                {
                    stack.Push(i);
                }
            }

            int ans = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (stack.Count == 0)
                    break;
                while (stack.Count > 0 && nums[i] >= nums[stack.Peek()])
                {
                    ans = Math.Max(ans, i - stack.Pop());
                }
            }
            return ans;
        }
    }
}
