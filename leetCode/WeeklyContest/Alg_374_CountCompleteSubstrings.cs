using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode.WeeklyContest
{
    public class Alg_374_CountCompleteSubstrings
    {

        public int CountCompleteSubstrings1(string word, int k)
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
                    string ss = word.Substring(splitIndex, (i - splitIndex));
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
            int len = word.Length - k * 2;
            var dictStep = new Dictionary<int, Dictionary<char, int>>();
            for (int i = 0; i <= len; i++)
            {
                if (!dictNode.ContainsKey(i))
                {
                    continue;
                }
                var dict = dictNode[i];
                bool bl = true;
                foreach (var item in dict)
                {
                    if (item.Value > k)
                    {
                        bl = false;
                        break;
                    }
                }
                if (bl)
                {
                    dictStep.Add(i, new Dictionary<char, int>(dict));
                }


            }
            var indexList = dictNode.Keys.ToList();
            int max = indexList[indexList.Count - 1];
            for (int step = 2 * k; step <= word.Length; step += k)
            {
                dictStep = MergeDictNode(dictNode, max, k, dictStep);

                foreach (var item in dictStep)
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
             int max, int k, Dictionary<int, Dictionary<char, int>> dictStep)
        {
            Dictionary<int, Dictionary<char, int>> dictNodeRes = new Dictionary<int, Dictionary<char, int>>();

            foreach (var dictPre in dictStep)
            {
                int nextIndex = dictPre.Key + k;
                if (nextIndex > max)
                {
                    continue;
                }
                if (!dictNode.ContainsKey(nextIndex))
                {
                    continue;
                }
                bool bl = true;
                var dict = dictNode[nextIndex];
                foreach (var item2 in dict)
                {
                    if (!dictPre.Value.ContainsKey(item2.Key))
                    {
                        dictPre.Value.Add(item2.Key, 0);
                    }
                    dictPre.Value[item2.Key] += item2.Value;
                    if (dictPre.Value[item2.Key] > k)
                    {
                        bl = false;
                        break;
                    }

                }
                if (bl)
                {
                    dictNodeRes.Add(nextIndex, dictPre.Value);
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
                if (dict[nextChar] <= k)
                {
                    AddNode(dictNode, index, dict);
                }
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
                    string ss = word.Substring(splitIndex, (i - splitIndex));
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
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in word)
            {
                AddCount(item, dict, 1);
            }
            if (dict.Count == 1 && k == 1)
            {
                return dict[word[0]];
            }
            else
            {
                int count = 0;
                foreach (var item in list)
                {
                    int num = GetWordWindowCount(item, k);
                    count += num;
                }
                return count;
            }

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
        private void AddCount(char ss, Dictionary<char, int> dict, int count)
        {
            if (!dict.ContainsKey(ss))
            {
                dict.Add(ss, 0);
            }
            dict[ss] += count;
        }
        private int GetWordWindowCount(string word, int k)
        {
            int total = 0;
            for (int step = k; step <= word.Length; step += k)
            {
                int num = GetWordWindowStep(word, step, k);
                total += num;
            }

            return total;
        }
        private int GetWordWindowStep(string word, int step, int k)
        {
            int total = 0;
            int index = 0;
            int end = step;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = index; i < end; i++)
            {
                AddCount(word[i], dict, 1);
            }
            if (CheckAns(dict, k))
            {
                total++;
            }
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
                if (dict[nextChar] == k)
                {
                    bool bl = true;
                    if (dict.ContainsKey(preChar) && dict[preChar] != k)
                    {
                        bl = false;
                    }
                    if (bl && CheckAns(dict, k))
                    {
                        total++;
                    }
                }

                end++;
                index++;
            }
            return total;
        }

        private bool CheckAns(Dictionary<char, int> dict, int k)
        {
            foreach (var item in dict)
            {
                if (item.Value != k)
                    return false;
            }
            return true;
        }

        private int LeftWindows(string word, int step, int k,Dictionary<char, int> dict)
        {
            return 0;
        }
        private int RightWindows(string word, int step, int k)
        {
            return 0;
        }


        private int GetWordPointCount(string word, int k)
        {
            if (word.Length < k)
                return 0;
            int total = 0;
            int baseIndex = 0;
            int end = word.Length;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Dictionary<int, HashSet<string>> dictSubWord = new Dictionary<int, HashSet<string>>();
            List<char> list = new List<char>();
            List<Node> listIndex = new List<Node>();
            int wordCount = 0;
            while (baseIndex < end)
            {
                int i = baseIndex;
                while (i < end)
                {
                    var ch = word[i];
                    list.Add(ch);
                    AddCount(ch, dict, 1);
                    wordCount++;
                    if (dict[ch] == k)
                    {
                        if (CheckWord(dict, k))
                        {
                            int start = i - (wordCount - 1);
                            listIndex.Add(new Node(start, wordCount));
                            wordCount = 0;
                        }
                    }
                    else if (dict[ch] > k)
                    {
                        ComputeCount(listIndex, word, dictSubWord);
                        listIndex.Clear();
                    }
                }
            }


            return total;
        }

        private void ComputeCount(List<Node> listIndex, string word, Dictionary<int, HashSet<string>> dictSubWord)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listIndex.Count; i++)
            {
                sb.Clear();
                var currentNode = listIndex[i];
                string ss = word.Substring(currentNode.Index, currentNode.Length);

                AddAns(dictSubWord, currentNode.Index, ss);
                sb.Append(ss);
                for (int j = i + 1; j < listIndex.Count; j++)
                {
                    var nextNode = listIndex[j];
                    string ss2 = word.Substring(nextNode.Index, nextNode.Length);
                    sb.Append(ss2);
                    AddAns(dictSubWord, currentNode.Index, sb.ToString());
                }
            }
        }
        private void AddAns(Dictionary<int, HashSet<string>> dictSubWord, int index, string sub)
        {
            if (!dictSubWord.ContainsKey(index))
            {
                dictSubWord.Add(index, new HashSet<string>());
            }
            if (!dictSubWord[index].Contains(sub))
            {
                dictSubWord[index].Add(sub);
            }

        }

        class Node
        {
            public int Index;
            public int Length;
            public Node(int index, int length)
            {
                this.Index = index;
                this.Length = length;
            }
        }

    }
}
