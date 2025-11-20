using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1151_1200
{
    public class _1190_ReverseSubstringsBetweenEachPairOfParenthesesAlg
    {
        public string ReverseParentheses(string s)
        {
            int n = s.Length;
            int[] pair = new int[n];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else if (s[i] == ')')
                {
                    int j = stack.Pop();
                    pair[i] = j;
                    pair[j] = i;
                }
            }

            StringBuilder sb = new StringBuilder();
            int index = 0, step = 1;
            while (index < n)
            {
                if (s[index] == '(' || s[index] == ')')
                {
                    index = pair[index];
                    step = -step;
                }
                else
                {
                    sb.Append(s[index]);
                }
                index += step;
            }
            return sb.ToString();

        }
    }
}
