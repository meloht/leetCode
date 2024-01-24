using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _242_ValidAnagramAlg
    {
        public bool IsAnagram1(string s, string t)
        {
            int[] arr1 = GetArr(s);
            int[] arr2 = GetArr(t);

            return arr1.SequenceEqual(arr2);
        }

        private int[] GetArr(string s)
        {
            int[] arr = new int[26];
            foreach (var item in s)
            {
                int ch = item - 'a';
                arr[ch]++;
            }
            return arr;
        }

        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                int ch1 = s[i] - 'a';
                int ch2 = t[i] - 'a';
                arr[ch1]++;
                arr[ch2]--;

            }

            return arr.Count(p => p == 0) == 26;
        }
    }
}
