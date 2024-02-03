using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _389_FindTheDifferenceAlg
    {
        public char FindTheDifference1(string s, string t)
        {
            int[] arr1 = GetArr(s);
            int[] arr2 = GetArr(t);
            for (int i = 0; i < 26; i++)
            {
                if (arr2[i] != arr1[i])
                {
                    return Convert.ToChar(i + 'a');
                }
            }
            return ' ';
        }
        private int[] GetArr(string s)
        {
            int[] arr1 = new int[26];
            foreach (var item in s)
            {
                int i = item - 'a';
                arr1[i]++;
            }
            return arr1;
        }

        public char FindTheDifference(string s, string t)
        {
            int ret = 0;
            foreach (char ch in s)
            {
                ret ^= ch;
            }
            foreach (char ch in t)
            {
                ret ^= ch;
            }
            return (char)ret;
        }
    }
}
