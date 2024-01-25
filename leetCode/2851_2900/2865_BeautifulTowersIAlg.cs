using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2851_2900
{
    public class _2865_BeautifulTowersIAlg
    {
        public long MaximumSumOfHeights1(IList<int> maxHeights)
        {
            if (maxHeights.Count == 1)
                return maxHeights[0];
            long max = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < maxHeights.Count; i++)
            {
                int curr = maxHeights[i];
                if (stack.Count > 0)
                {
                    if (stack.Peek() > curr)
                    {
                        stack.Clear();
                        stack.Push(curr);

                        long num = GetNum(i - 1, maxHeights);
                        max = Math.Max(max, num);

                    }
                    else
                    {
                        stack.Push(curr);
                    }
                }
                else
                {
                    stack.Push(curr);
                }

            }
            if (stack.Count > 0)
            {
                long num = GetNum(maxHeights.Count - 1, maxHeights);
                max = Math.Max(max, num);
            }

            return max;
        }
        private long GetNum(int peekIndex, IList<int> maxHeights)
        {
            long max = 0;
            int prev = maxHeights[peekIndex];
            max += prev;
            for (int i = peekIndex - 1; i >= 0; i--)
            {
                int num = Math.Min(prev, maxHeights[i]);
                max += num;
                prev = num;
            }
            prev = maxHeights[peekIndex];
            for (int i = peekIndex + 1; i < maxHeights.Count; i++)
            {
                int num = Math.Min(prev, maxHeights[i]);
                max += num;
                prev = num;
            }

            return max;
        }

        public long MaximumSumOfHeights(IList<int> maxHeights)
        {
            int n = maxHeights.Count;
            long max = 0;
            long[] prefix = new long[n];
            long[] suffix = new long[n];
            Stack<int> stackLeft = new Stack<int>();
            Stack<int> stackRight = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stackLeft.Count > 0 && maxHeights[i] < maxHeights[stackLeft.Peek()])
                {
                    stackLeft.Pop();
                }
                if (stackLeft.Count == 0)
                {
                    prefix[i] = (long)(i + 1) * maxHeights[i];
                }
                else
                {
                    prefix[i] = prefix[stackLeft.Peek()] + (long)(i - stackLeft.Peek()) * maxHeights[i];
                }
                stackLeft.Push(i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                while (stackRight.Count > 0 && maxHeights[i] < maxHeights[stackRight.Peek()])
                {
                    stackRight.Pop();
                }
                if (stackRight.Count == 0)
                {
                    suffix[i] = (long)(n - i) * maxHeights[i];
                }
                else
                {
                    suffix[i] = suffix[stackRight.Peek()] + (long)(stackRight.Peek() - i) * maxHeights[i];
                }
                stackRight.Push(i);

                max = Math.Max(max, prefix[i] + suffix[i] - maxHeights[i]);
            }
            return max;
        }
    }
}
