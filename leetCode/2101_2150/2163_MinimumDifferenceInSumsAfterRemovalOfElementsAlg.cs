using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2163_MinimumDifferenceInSumsAfterRemovalOfElementsAlg
    {
        public long MinimumDifference(int[] nums)
        {
            int m = nums.Length;
            int n = m / 3;
            PriorityQueue<int, int> queueMin = new PriorityQueue<int, int>();
            long sum = 0;

            for (int i = m - 1; i >= m - n; i--)
            {
                queueMin.Enqueue(nums[i], nums[i]);
                sum += nums[i];
            }

            long[] sufMax = new long[m - n + 1];
            sufMax[m - n] = sum;
            for (int i = m - n - 1; i >= n; i--)
            {
                int val = nums[i];
                if (val > queueMin.Peek())
                {
                    sum += val - queueMin.Dequeue();
                    queueMin.Enqueue(val, val);
                }
                sufMax[i] = sum;
            }

            PriorityQueue<int, int> queueMax = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            long preMin = 0;
            for (int i = 0; i < n; i++)
            {
                queueMax.Enqueue(nums[i], nums[i]);
                preMin += nums[i];
            }

            long ans = preMin - sufMax[n]; // i=n-1 时的答案
            for (int i = n; i < m - n; i++)
            {
                int v = nums[i];
                if (v < queueMax.Peek())
                {
                    preMin += v - queueMax.Dequeue();
                    queueMax.Enqueue(v, v);
                }
                ans = Math.Min(ans, preMin - sufMax[i + 1]);
            }
            return ans;


        }
    }
}
