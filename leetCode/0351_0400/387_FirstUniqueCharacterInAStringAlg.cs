using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _387_FirstUniqueCharacterInAStringAlg
    {
        public int FirstUniqChar(string s)
        {
            int[] dict = new int[26];

            foreach (var item in s)
            {
                int index = item - 'a';
                dict[index]++;

            }
            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'a';
                if (dict[index] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
