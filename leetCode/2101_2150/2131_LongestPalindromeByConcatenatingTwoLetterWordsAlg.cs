using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2131_LongestPalindromeByConcatenatingTwoLetterWordsAlg
    {
        public int LongestPalindrome(string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int ans = 0;
            HashSet<string> set =[];
            foreach (var item in words)
            {
                if (item[0] == item[1])
                {
                    set.Add(item);
                }
                string rel = new string([item[1], item[0]]);
                if (dict.ContainsKey(rel))
                {
                    ans += 4;
                    dict[rel]--;
                    if (dict[rel] <= 0)
                    {
                        dict.Remove(rel);
                        if (rel == item)
                        {
                            set.Remove(rel);
                        }
                       
                    }
                    continue;
                }
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            if (set.Count > 0)
            {
                ans += 2;
            }
            return ans;
        }
    }
}
