using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _680_ValidPalindromeIIAlg
    {
        public bool ValidPalindrome(string s)
        {

            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return ValidPalindrome(s, i, j - 1) || ValidPalindrome(s, i + 1, j);
                }
                i++;
                j--;
            }
            return true;
        }

        private bool ValidPalindrome(string s, int left, int right)
        {
            for (int i = left,j=right; i < j; i++,j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
