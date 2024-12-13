using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3264_FinalArrayStateAfterKMultiplicationOperationsIAlg
    {
        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) =>
            {
                if (nums[x] == nums[y])
                {
                    return x.CompareTo(y);
                }
                else
                {
                    return nums[x].CompareTo(nums[y]);
                }
            }));

            for (int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(i, i);
            }


            for (int i = 0; i < k; i++)
            {
                int idx = queue.Dequeue();
                nums[idx] = nums[idx] * multiplier;
                queue.Enqueue(idx, idx);
            }

            return nums;
        }
    }
}
