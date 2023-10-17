using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class LongestValidParenthesesAlg
    {
        public int LongestValidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int max = 0;
            int tempLen = 0;
            string prefix = "()";
            string sub = s;
            while (true)
            {
                if (sub.StartsWith(prefix))
                {
                    tempLen += prefix.Length;
                    if (tempLen > max)
                    {
                        max = tempLen;
                    }
                    sub = sub.Substring(prefix.Length);
                    if (sub.Length == 0 || sub.Length == 1)
                    {
                        break;
                    }

                }
                else
                {
                    tempLen = 0;
                    sub = sub.Substring(1);
                    if (sub.Length == 0 || sub.Length == 1)
                    {
                        break;
                    }
                }
            }
            return max;
        }
    }
}
