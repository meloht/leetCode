using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1021_RemoveOutermostParenthesesAlg
    {
        public string RemoveOuterParentheses(string s)
        {
            StringBuilder ans = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            StringBuilder sb = new StringBuilder();
            foreach (var item in s)
            {
                sb.Append(item);
                if (item == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(item);
                }
                if (stack.Count == 0)
                {
                    string ss = sb.ToString();
                    if (ss.Length > 0)
                    {
                        ans.Append(ss.Substring(1, ss.Length - 2));
                    }

                    sb.Clear();
                }
            }


            return ans.ToString();
        }

        public string RemoveOuterParentheses2(string s)
        {
            StringBuilder res = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == ')')
                {
                    stack.Pop();
                }
                if (stack.Count > 0)
                {
                    res.Append(c);
                }
                if (c == '(')
                {
                    stack.Push(c);
                }
            }
            return res.ToString();
        }

        public string RemoveOuterParentheses3(string s)
        {
            int level = 0;
            StringBuilder res = new StringBuilder();
            foreach (char c in s)
            {
                if (c == ')')
                {
                    level--;
                }
                if (level > 0)
                {
                    res.Append(c);
                }
                if (c == '(')
                {
                    level++;
                }
            }
            return res.ToString();
        }


    }
}
