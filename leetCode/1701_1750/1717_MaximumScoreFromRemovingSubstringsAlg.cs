using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1701_1750
{
    public class _1717_MaximumScoreFromRemovingSubstringsAlg
    {
        public int MaximumGain(string s, int x, int y)
        {
            Stack<char> stack = new Stack<char>();
            int ans = 0;
            foreach (var item in s)
            {
                if (x > y)
                {
                    if (stack.Count > 0 && stack.Peek() == 'a' && item == 'b')
                    {
                        stack.Pop();
                        ans += x;
                        continue;
                    }

                }
                else
                {
                    if (stack.Count > 0 && stack.Peek() == 'b' && item == 'a')
                    {
                        stack.Pop();
                        ans += y;
                        continue;
                    }
                }
                stack.Push(item);

            }
            Stack<char> stack2 = new Stack<char>();
            while (stack.Count > 0)
            {
                var item = stack.Pop();
                if (stack2.Count > 0 && stack2.Peek() == 'a' && item == 'b')
                {
                    stack2.Pop();
                    ans += y;
                }
                else if (stack2.Count > 0 && stack2.Peek() == 'b' && item == 'a')
                {
                    stack2.Pop();
                    ans += x;
                }
                else
                {
                    stack2.Push(item);
                }
               
            }
            return ans;
        }
    }
}
