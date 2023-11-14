using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class ValidParenthesesAlg
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('(', ')');
            dict.Add('{', '}');
            dict.Add('[', ']');

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count > 0)
                {
                    char tem = stack.Pop();
                    if (dict.ContainsKey(tem))
                    {
                        char target = dict[tem];
                        if (target != s[i])
                        {
                            stack.Push(tem);
                            stack.Push(s[i]);
                        }
                    }
                    else
                    {
                        stack.Push(s[i]);
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            if (stack.Count > 0)
                return false;
            return true;
        }
    }
}
