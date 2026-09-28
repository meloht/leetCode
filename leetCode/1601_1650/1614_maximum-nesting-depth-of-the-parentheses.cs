using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1601_1650
{
    public class _1614_maximum_nesting_depth_of_the_parentheses
    {
        public int MaxDepth(string s)
        {
            int ans = 0;
            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    ans = Math.Max(ans, stack.Count);
                    stack.Pop();
                }
            }
            return ans;
        }
    }
}
