using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1111_MaximumNestingDepthOfTwoValidParenthesesStringsAlg
    {
        public int[] MaxDepthAfterSplit(string seq)
        {
            int d = 0;
            int length = seq.Length;
            int[] ans = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (seq[i] == '(')
                {
                    ++d;
                    ans[i] = d % 2;
                }
                else
                {
                    ans[i] = d % 2;
                    --d;
                }
            }
            return ans;

        }
    }
}
