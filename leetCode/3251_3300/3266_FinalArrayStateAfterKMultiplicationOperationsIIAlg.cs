using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3266_FinalArrayStateAfterKMultiplicationOperationsIIAlg
    {
        int Mod = 1_000_000_007;
        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            if (multiplier == 1)
            { // 数组不变
                return nums;
            }
            int n = nums.Length;
            int max = 0;
            long[] ans = new long[n];
            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[i];
            }
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) =>
            {
                if (ans[x] == ans[y])
                {
                    return x.CompareTo(y);
                }
                else
                {
                    return ans[x].CompareTo(ans[y]);
                }
            }));

         
            for (int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(i, i);
                max = Math.Max(max, nums[i]);
            }

            for (; k > 0 && nums[queue.Peek()] < max; k--)
            {
                int idx = queue.Dequeue();
                ans[idx] = ans[idx] * multiplier;
                queue.Enqueue(idx, idx);
            }
          

            for (int i = 0; i < n; i++)
            {
                int idx = queue.Dequeue();

                nums[idx] = (int)(ans[idx] % Mod * pow(multiplier, k / n + (i < k % n ? 1 : 0)) % Mod);
            }

            return nums;
        }

        private long pow(long x, int n)
        {
            long res = 1;
            for (; n > 0; n /= 2)
            {
                if (n % 2 > 0)
                {
                    res = res * x % Mod;
                }
                x = x * x % Mod;
            }
            return res;
        }


    }
}
