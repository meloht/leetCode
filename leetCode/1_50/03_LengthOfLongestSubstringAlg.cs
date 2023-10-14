using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class LengthOfLongestSubstringAlg
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s == null)
                return 0;
            if (s == string.Empty)
                return 0;
            List<char> ls = new List<char>();
            HashSet<char> dict = new HashSet<char>();
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int index = 0;
                char item = s[i];
                if (dict.Contains(item))
                {
                    index = ls.IndexOf(item);

                    if (ls.Count > max)
                    {
                        max = ls.Count;
                    }
                    RemoveItem(dict, ls, index);
                }
                ls.Add(s[i]);
                dict.Add(s[i]);
                if (ls.Count > max)
                {
                    max = ls.Count;
                }
            }
            return max;
        }
        public static void RemoveItem(HashSet<char> dict, List<char> ls, int index)
        {
            List<char> list = new List<char>();
            for (int i = 0; i <= index; i++)
            {
                list.Add(ls[i]);
            }
            foreach (var item in list)
            {
                dict.Remove(item);
                ls.Remove(item);
            }

        }
    }
}
