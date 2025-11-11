using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1124_LongestWellPerformingIntervalAlg
    {

        public int LongestWPI(int[] hours)
        {
            int n = hours.Length;
            int ans = 0;
            int[] s = new int[n + 1];
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            for (int i = 1; i <= n; i++)
            {
                s[i] = s[i - 1] + (hours[i - 1] > 8 ? 1 : -1);
                if (s[i] < s[stack.Peek()])
                {
                    stack.Push(i);
                }
            }
            for (int i = n; i > 0; --i)
                while (stack.Count>0 && s[i] > s[stack.Peek()])
                    ans = Math.Max(ans, i - stack.Pop()); // [栈顶,i) 可能是最长子数组
            return ans;

        }
    }
}
