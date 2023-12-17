using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _125_ValidPalindromeAlg
    {
        public bool IsPalindrome(string s)
        {

            List<char> arr = new List<char>();
            foreach (char c in s)
            {
                if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                {
                    arr.Add(c);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    arr.Add(Char.ToLower(c));
                }

            }
            if (arr.Count <= 1)
                return true;

            int mid = arr.Count / 2;
            if (arr.Count % 2 == 1)
            {
                mid++;
            }
            for (int i = 0, j = arr.Count - 1; i < mid; i++, j--)
            {
                if (arr[i] != arr[j])
                    return false;
            }
            return true;
        }
    }
}
