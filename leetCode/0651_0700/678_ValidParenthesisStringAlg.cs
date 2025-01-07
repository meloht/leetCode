using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _678_ValidParenthesisStringAlg
    {
        public bool CheckValidString(string s)
        {
            int leftMin = 0;
            int leftMax = 0;
            foreach (var c in s)
            {
                if (c == '(')
                {
                    leftMin++;
                    leftMax++;
                }
                else if (c == ')')
                {
                    leftMin--;
                    leftMax--;
                }
                else
                {
                    leftMin--;
                    leftMax++;
                }
                if (leftMax < 0)
                {
                    return false;
                }
                leftMin = Math.Max(leftMin, 0);
            }
            return leftMin == 0;
        }
    }
}
