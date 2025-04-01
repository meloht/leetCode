using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _856_ScoreOfParenthesesAlg
    {
        public int ScoreOfParentheses1(string s)
        {
            int ans = 0;
            int n = s.Length;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {

                if (s[i] == '(')
                {
                    stack.Push(0);
                }
                else
                {
                    int num = 0;
                    var pre = stack.Pop();
                    if (pre == 0)
                    {
                        num = 1;
                    }
                    else
                    {
                        num = 2 * pre;
                    }
                    if (stack.Count > 0)
                    {
                        int nn = stack.Pop() + num;
                        stack.Push(nn);
                    }
                    else
                    {
                        ans += num;
                    }
                }
            }

            return ans;
        }
        public int ScoreOfParentheses(string s)
        {
            int num = 0;
            int n = s.Length;
            int ans = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(')
                {
                    num++;
                }
                else
                {
                    num--;
                    if (s[i - 1] == '(')
                    {
                        ans += (1 << num);
                    }
                }

            }

            return ans;
        }




    }
}
