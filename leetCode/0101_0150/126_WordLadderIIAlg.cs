using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetCode._0101_0150
{
    public class _126_WordLadderIIAlg
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            List<IList<string>> res = new List<IList<string>>();
            if (!wordList.Contains(endWord))
                return res;

            List<int> lsIndex = new List<int>();
            for (int i = 0; i < beginWord.Length; i++)
            {
                if (beginWord[i] != endWord[i])
                {
                    lsIndex.Add(i);
                }
            }

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            DictInit(lsIndex.ToArray(), endWord, new int[] { }, wordList.ToArray(), dict);

            if (dict.Count == 0)
                return res;

            var wordDict = GetNextWords(wordList);

            List<string[]> ress = new List<string[]>();

            var keys = dict.Keys.ToList();

            foreach (int itemIndex in lsIndex)
            {
                string key = itemIndex.ToString();
                if (!dict.ContainsKey(key))
                {
                    continue;
                }
                List<string> path = new List<string>();
                path.Add(beginWord);
                var data = dict[key];
                HashSet<string> set = new HashSet<string>(data);
                var nextList = GetDiffOneBegin(beginWord, wordList, set);
                foreach (string next in nextList)
                {
                    path.Add(next);
                    if (!set.Contains(next))
                    {
                        foreach (var item in data)
                        {
                            AddPath(next, item, path, ress, wordDict);
                        }
                    }
                   
                }
            }


            return res;
        }
        private void AddNext(int len, string current, string preKey, List<string> keys, Dictionary<string, List<string>> dict,
            Dictionary<string, List<string>> wordDict)
        {
            List<string[]> ress = new List<string[]>();
            var keyss = keys.Where(p => p.Contains(preKey) && p.Length == len);
            foreach (var itemKey in keyss)
            {
                var nexts = dict[itemKey];
                foreach (var itemNext in nexts)
                {
                    List<string> path = new List<string>();
                    AddPath(current, itemNext, path, ress, wordDict);
                    AddNext(len + 1, itemNext, itemKey, keys, dict, wordDict);
                }
            }
        }

        private void AddPath(string current, string target, List<string> list, List<string[]> res, Dictionary<string, List<string>> dict)
        {
            if (!dict.ContainsKey(current))
            {
                return;
            }
            var ls = dict[current];
            HashSet<string> set = new HashSet<string>(list);
            var ws = ls.Where(p => !set.Contains(p)).ToList();
            foreach (var word in ws)
            {
                if (IsDiffOneChar(word, target))
                {
                    list.Add(word);
                    res.Add(list.ToArray());
                    list.RemoveAt(list.Count - 1);
                    return;
                }
            }
            foreach (var word in ws)
            {
                list.Add(word);
                AddPath(word, target, list, res, dict);
                list.RemoveAt(list.Count - 1);
            }

        }

        private List<string> GetDiffOneBegin(string beginWord, IList<string> wordList, HashSet<string> targetList)
        {
            List<string> ls = new List<string>();
            List<string> ls2 = new List<string>();
            for (int j = 0; j < beginWord.Length; j++)
            {
                foreach (var item in wordList)
                {
                    if (IsDiffOneChar(item, beginWord, j))
                    {
                        if (targetList.Contains(item))
                        {
                            ls2.Add(item);
                        }
                        else
                        {
                            ls.Add(item);
                        }
                    }
                }
            }

            if (ls2.Count > 0)
            {
                return ls2;
            }
            return ls;

        }
        private Dictionary<string, List<string>> GetNextWords(IList<string> wordList)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (var word in wordList)
            {
                List<string> ls = new List<string>();
                for (int i = 0; i < word.Length; i++)
                {
                    foreach (var item in wordList)
                    {
                        if (item == word)
                            continue;
                        if (IsDiffOneChar(item, word, i))
                        {
                            ls.Add(item);
                        }
                    }
                }

                dict.Add(word, ls);
            }


            return dict;
        }

        private bool IsDiffOneChar(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (IsDiffOneChar(s1, s2, i))
                    return true;
            }
            return false;
        }
        private bool IsDiffOneChar(string s1, string s2, int index)
        {
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (i == index)
                {
                    if (s1[i] != s2[i])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (s1[i] == s2[i])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

            }

            if (count == s1.Length)
                return true;

            return false;
        }

        private void DictInit(int[] lsIndex, string endWord, int[] lsIndexUsed, string[] words,
            Dictionary<string, List<string>> dict)
        {
            for (int i = 0; i < lsIndex.Length; i++)
            {
                var arr = lsIndexUsed.ToList();
                int index = lsIndex[i];

                arr.Add(index);
                arr.Sort();
                HashSet<int> list = new HashSet<int>(arr);
                List<string> listWord = new List<string>();
                foreach (var item in words)
                {
                    int count = 0;
                    for (int j = 0; j < endWord.Length; j++)
                    {
                        bool bl11 = list.Contains(j);

                        if (bl11)
                        {
                            if (endWord[j] == item[j])
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (endWord[j] != item[j])
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (count == endWord.Length)
                    {
                        string key = string.Join("-", arr);
                        if (!dict.ContainsKey(key))
                        {
                            dict.Add(key, new List<string>());
                        }

                        dict[key].Add(item);
                    }
                    else
                    {
                        listWord.Add(item);
                    }
                }
                if (listWord.Count < words.Length)
                {
                    var newArr = lsIndex.Where(p => p != index).ToArray();

                    DictInit(newArr, endWord, arr.ToArray(), listWord.ToArray(), dict);
                }

            }
        }





    }
}
