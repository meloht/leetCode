using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _383_RansomNoteAlg
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] dict1 = GetCharDict(ransomNote);

            foreach (char ch in magazine)
            {
                int index = ch - 'a';
                if (dict1[index] > 0)
                {
                    dict1[index]--;
                }

            }
            int count = dict1.Count(p => p == 0);
            if (count == 26)
                return true;
            return false;
        }

        private int[] GetCharDict(string s)
        {
            int[] arr = new int[26];
            foreach (char c in s)
            {
                int index = c - 'a';
                arr[index]++;
            }
            return arr;
        }
    }
}
