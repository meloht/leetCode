using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _214_ShortestPalindromeAlg
    {
        public string ShortestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            if (s.Length <= 1)
            {
                return s;
            }
            if (s.Length == 2)
            {
                if (s[0] == s[1])
                    return s;
                return $"{s[1]}{s}";
            }

            int right = 1;
            for (int i = s.Length, j = s.Length - 1; i >= 2; i--, j--)
            {
                var res = GetMidIndex(i, s);
                if (res != -1)
                {
                    right = res + 1;
                    break;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= right; i--)
            {
                sb.Append(s[i]);
            }

            string ans = $"{sb.ToString()}{s}";

            return ans;
        }

        private int GetMidIndex(int len, string s)
        {
            int mid = len / 2;
            int left = mid;
            int right = mid + 1;
            if (len % 2 > 0)
            {
                left = mid - 1;
                right = mid + 1;
            }
            else
            {
                right = mid;
                left = mid - 1;
            }

            for (int i = left, j = right; i >= 0; i--, j++)
            {
                if (s[i] != s[j])
                    return -1;
                if (i == 0)
                {
                    return j;
                }
            }
            return -1;
        }

      
    }
}
