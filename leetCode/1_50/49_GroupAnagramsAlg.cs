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
            Dictionary<string, int> dictArr = GetArrDict(strs);

            while (dictArr.Count > 0)
            {
                var arrData = dictArr.First();
                string str = arrData.Key;
                if (!dict.ContainsKey(str))
                {
                    dict.Add(str, new List<string>());
                    for (int i = 0; i < arrData.Value; i++)
                    {
                        dict[str].Add(str);
                    }
                    dictArr.Remove(str);
                }

                Dictionary<char, int> dict1 = GetWordDict(str);
                var arr = dictArr.Keys.Where(p => p != str && p.Length == str.Length).ToList();
                foreach (var item in arr)
                {
                    Dictionary<char, int> dict2 = GetWordDict(item);
                    if (IsSameWord(dict1, dict2))
                    {
                        int num = dictArr[item];
                        for (int i = 0; i < num; i++)
                        {
                            dict[str].Add(item);
                        }
                        dictArr.Remove(item);
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

        private Dictionary<string, int> GetArrDict(string[] strs)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string str in strs)
            {
                if (!dict.ContainsKey(str))
                {
                    dict.Add(str, 1);
                }
                else
                {
                    dict[str]++;
                }
            }
            return dict;
        }


    }
}
