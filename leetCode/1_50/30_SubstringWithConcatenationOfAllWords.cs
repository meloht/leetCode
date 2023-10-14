using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class SubstringWithConcatenationOfAllWords
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            List<int> result = new List<int>();
            if (string.IsNullOrEmpty(s))
                return result;
            if (words == null || words.Length == 0)
                return result;


            int len = words.Length;
            int wordLen = words[0].Length;

            if (s.Length < len * wordLen)
            {
                return result;
            }


            HashSet<string> resultArr = new HashSet<string>();
            for (int i = 0; i < words.Length; i++)
            {
                List<string> list = new List<string>(words);
                string item = words[i];
                list.RemoveAt(i);
                if (list.Count > 0)
                {
                    BuldStringList(list, item, resultArr);
                }
                else
                {
                    resultArr.Add(item);
                }

            }


            foreach (var item in resultArr)
            {
                string ss = s;
                int index = ss.IndexOf(item);
                int total = 0;
                while (index != -1)
                {
                    total += index;
                    result.Add(total);

                    ss = ss.Substring(index + 1);
                    total += 1;
                    index = ss.IndexOf(item);

                }
            }

            return result;
        }


        private void BuldStringList(List<string> ls, string str, HashSet<string> result)
        {
            var words = ls.ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                List<string> list = new List<string>(words);
                string item = words[i];
                list.RemoveAt(i);
                string strna = $"{str}{item}";

                if (list.Count == 0)
                {
                    result.Add(strna);

                }
                else
                {
                    BuldStringList(list, strna, result);
                }
            }
        }
    }
}
