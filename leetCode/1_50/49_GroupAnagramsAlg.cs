using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _49_GroupAnagramsAlg
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> result = new List<IList<string>>();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            HashSet<string> keys = new HashSet<string>(strs);

            while (keys.Count > 0)
            {
                var str = keys.First();
                if (!dict.ContainsKey(str))
                {
                    dict.Add(str, new List<string>());
                    dict[str].Add(str);
                    keys.Remove(str);
                }

                Dictionary<char, int> dict1 = GetWordDict(str);
                var arr = keys.Where(p => p != str && p.Length == str.Length).ToList();
                foreach (var item in arr)
                {
                    Dictionary<char, int> dict2 = GetWordDict(item);
                    if (IsSameWord(dict1, dict2))
                    {
                        dict[str].Add(item);
                        keys.Remove(item);
                    }
                }
            }

            foreach (var key in dict) 
            {
                result.Add(key.Value);
            }
            return result;
        }
        private Dictionary<char, int> GetWordDict(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char item in str)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            return dict;
        }
        private bool IsSameWord(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            foreach (var item in dict1)
            {
                if (!dict2.ContainsKey(item.Key))
                    return false;

                if (dict2[item.Key] != item.Value)
                    return false;
            }
            return true;
        }


    }
}
