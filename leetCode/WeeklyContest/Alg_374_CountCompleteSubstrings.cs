using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest
{
    public class Alg_374_CountCompleteSubstrings
    {
        public int CountCompleteSubstrings(string word, int k)
        {

            if (word.Length < k)
                return 0;

            List<string> list = new List<string>();
            int splitIndex = 0;
            for (int i = 1; i < word.Length; i++)
            {
                var chpre = word[i - 1];
                var chcurr = word[i];
                if (Math.Abs(chpre - chcurr) > 2)
                {
                    string ss = word.Substring(splitIndex, i);
                    list.Add(ss);
                    splitIndex = i;
                }
            }
            if (list.Count > 0)
            {
                string sss = word.Substring(splitIndex);
                list.Add(sss);
            }
            else
            {
                list.Add(word);
            }
            int count = 0;
            foreach (var item in list)
            {
                int num = GetWordCount(item, k);
                count += num;
            }
            return count;
        }
        private int GetWordCount(string word, int k)
        {
            if (word.Length < k)
                return 0;
            Dictionary<int, Dictionary<char, int>> dictNode = GetDictNode(word, k);

            int total = 0;
            foreach (var item in dictNode)
            {
                if (CheckWord(item.Value, k))
                {
                    total++;
                }
            }
            var indexList = dictNode.Keys.ToList();
            int max = indexList.Max();
            for (int step = 2 * k; step <= word.Length; step += k)
            {
                int len = word.Length - step;
                var itemDict = MergeDictNode(dictNode, len, k, step / k, max, indexList);

                foreach (var item in itemDict)
                {
                    if (CheckWord(item.Value, k))
                    {
                        total++;
                    }
                }
            }

            return total;
        }
        private Dictionary<int, Dictionary<char, int>> MergeDictNode(Dictionary<int, Dictionary<char, int>> dictNode,
            int len, int k, int total, int max, List<int> indexList)
        {
            Dictionary<int, Dictionary<char, int>> dictNodeRes = new Dictionary<int, Dictionary<char, int>>();

            for (int i = 0; i <= len; i++)
            {
                int n = 1;
                var dictPre = new Dictionary<char, int>(dictNode[i]);
                int index = i + k;
                while (n <= total && index <= max)
                {
                    var dict = dictNode[index];
                    foreach (var item in dict)
                    {
                        AddCount(item.Key, dictPre, item.Value);
                    }
                    if (!dictNodeRes.ContainsKey(indexList[i]))
                    {
                        dictNodeRes.Add(indexList[i], dictPre);
                    }
                    index += k;
                    n++;
                }

            }

            return dictNodeRes;
        }
        private Dictionary<int, Dictionary<char, int>> GetDictNode(string word, int k)
        {
            Dictionary<int, Dictionary<char, int>> dictNode = new Dictionary<int, Dictionary<char, int>>();
            int index = 0;
            int end = k;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = index; i < end; i++)
            {
                AddCount(word[i], dict, 1);
            }
            AddNode(dictNode, index, dict);
            end++;
            index++;
            while (end <= word.Length)
            {
                int next = end - 1;
                int pre = index - 1;
                var preChar = word[pre];
                var nextChar = word[next];

                SubCount(preChar, dict);
                AddCount(nextChar, dict, 1);
                AddNode(dictNode, index, dict);
                end++;
                index++;
            }
            return dictNode;
        }

        private void AddNode(Dictionary<int, Dictionary<char, int>> dictNode, int index, Dictionary<char, int> dict)
        {
            if (!dictNode.ContainsKey(index))
            {
                dictNode.Add(index, new Dictionary<char, int>(dict));
            }
        }
        private void AddCount(char ss, Dictionary<char, int> dict, int count)
        {
            if (!dict.ContainsKey(ss))
            {
                dict.Add(ss, 0);
            }
            dict[ss] += count;
        }
        private void SubCount(char ss, Dictionary<char, int> dict)
        {
            if (dict.ContainsKey(ss))
            {
                dict[ss]--;
                if (dict[ss] <= 0)
                {
                    dict.Remove(ss);
                }
            }

        }

        private bool CheckWord(Dictionary<char, int> dict, int k)
        {
            foreach (var item in dict)
            {
                if (item.Value != k)
                {
                    return false;
                }
            }
            return true;
        }

        class Node
        {
            public int Step;
            public Dictionary<char, int> DictChar = new Dictionary<char, int>();
        }
    }
}
