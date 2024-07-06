using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _456_132PatternAlg
    {
        public bool Find132pattern1(int[] nums)
        {
            int[] leftMin = new int[nums.Length];
            int min = nums[0];
            leftMin[0] = min;

            for (int i = 1; i < nums.Length; i++)
            {
                min = Math.Min(min, nums[i]);
                leftMin[i] = min;
            }
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            for (int i = nums.Length - 1, j = nums.Length; i >= 0; i--, j--)
            {
                if (j < nums.Length)
                {
                    while (queue.Count > 0 && queue.Peek() <= leftMin[i])
                    {
                        queue.Dequeue();
                    }
                    if (nums[j] > leftMin[i])
                    {
                        queue.Enqueue(nums[j], nums[j]);
                    }
                }

                if (i - 1 >= 0 && queue.Count > 0 && nums[i] > queue.Peek())
                    return true;


            }
            return false;
        }

        public bool Find132pattern(int[] nums)
        {
            int n = nums.Length;

            Stack<int> stack = new Stack<int>();
            stack.Push(nums[n - 1]);

            int max = int.MinValue;

            for (int i = n - 2; i >= 0; i--)
            {
                if (nums[i] < max)
                {
                    return true;
                }
                while (stack.Count > 0 && nums[i] > stack.Peek())
                {
                    max = stack.Pop();
                }
                if (nums[i] > max)
                {
                    stack.Push(nums[i]);
                }
            }
            return false;
        }
    }
}
