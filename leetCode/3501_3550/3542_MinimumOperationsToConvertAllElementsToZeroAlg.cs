using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3501_3550
{
    public class _3542_MinimumOperationsToConvertAllElementsToZeroAlg
    {
        public int MinOperations(int[] nums)
        {
            int ans = 0;
            int top = -1; // 栈顶下标（把 nums 当作栈）
            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                while (top >= 0 && x < nums[top])
                {
                    top--; // 出栈
                    ans++;
                }
                // 如果 x 与栈顶相同，那么 x 与栈顶可以在同一次操作中都变成 0，x 无需入栈
                if (top < 0 || x != nums[top])
                {
                    nums[++top] = x; // 入栈
                }
            }

            return ans + top + (nums[0] > 0 ? 1 : 0);

        }
    }
}
