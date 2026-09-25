using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1151_1200
{
    public class _1160_find_words_that_can_be_formed_by_characters
    {
        public int CountCharacters(string[] words, string chars)
        {
            int[] map = new int[26];
            foreach (var item in chars)
            {
                map[item - 'a']++;
            }
            int ans = 0;
            foreach (var item in words)
            {

                int[] map1 = new int[26];
                foreach (var s in item)
                {
                    map1[s - 'a']++;
                }
                bool bl = true;
                for (int i = 0; i < 26; i++)
                {
                    if (map1[i] > map[i] && map1[i] > 0)
                    {
                        bl = false;
                        break;
                    }
                }
                if (bl)
                {
                    ans += item.Length;
                }
            }
            return ans;
        }
    }
}
