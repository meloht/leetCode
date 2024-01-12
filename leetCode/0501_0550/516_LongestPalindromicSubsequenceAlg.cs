using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _516_LongestPalindromicSubsequenceAlg
    {
        public int LongestPalindromeSubseq(string s)
        {
            int len = s.Length;
            if (len < 2)
                return 1;
            int maxlen = 0;
            int begin = 0;

            int[,] dp = new int[len + 1, len + 1];

            return 0;
        }
    }
}
