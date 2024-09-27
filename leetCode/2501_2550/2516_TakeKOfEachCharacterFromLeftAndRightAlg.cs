using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2501_2550
{

    public class _2516_TakeKOfEachCharacterFromLeftAndRightAlg
    {
        public int TakeCharacters(string s, int k)
        {
            int[] dict = new int[3];
            foreach (var item in s)
            {
                dict[item - 'a']++;
            }
            if (dict[0] < k || dict[1] < k || dict[2] < k)
                return -1;

            int max = 0;
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int c = s[i] - 'a';
                dict[c]--;
                while (dict[c] < k)
                {
                    dict[s[j] - 'a']++;
                    j++;
                }
                max = Math.Max(max, i - j + 1);
            }
            return s.Length - max;
        }
    }
}
