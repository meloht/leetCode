using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class PalindromeNumberAlg
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            string ss = x.ToString();
            int len = ss.Length / 2;
            for (int i = 0; i < len; i++)
            {
                if (ss[i] != ss[ss.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
