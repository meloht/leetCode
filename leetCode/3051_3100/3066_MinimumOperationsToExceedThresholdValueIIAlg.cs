using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3066_MinimumOperationsToExceedThresholdValueIIAlg
    {
        public int MinOperations(int[] nums, int k)
        {
            PriorityQueue<long, long> queue = new PriorityQueue<long, long>();

            foreach (var item in nums)
            {
                queue.Enqueue(item, item);
            }
            int ans = 0;
            while (queue.Count > 1 && queue.Peek() < k)
            {
                var num1 = queue.Dequeue();
                var num2 = queue.Dequeue();
                long n = Math.Min(num1, num2) * 2 + Math.Max(num1, num2);
                queue.Enqueue(n, n);
                ans++;
            }

            return ans;
        }
    }
}
