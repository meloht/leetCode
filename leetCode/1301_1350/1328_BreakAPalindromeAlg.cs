using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1301_1350
{
    public class _1328_BreakAPalindromeAlg
    {
        public string BreakPalindrome(string palindrome)
        {
            int n = palindrome.Length;
            if (n == 1)
                return "";
            int len = n / 2;
            char[] s=palindrome.ToCharArray();
            for (int i = 0; i < len; i++)
            {
                if (palindrome[i] != 'a')
                {
                    s[i] = 'a';
                    return new string(s);
                }
            }
            s[n - 1] = 'b';
            return new string(s);
        }
    }
}
