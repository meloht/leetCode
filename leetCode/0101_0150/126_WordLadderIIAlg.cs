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
        private Dictionary<string, List<string>> dictLen = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> wordDict = new Dictionary<string, List<string>>();
        private int MinCount = int.MaxValue;
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            List<IList<string>> res = new List<IList<string>>();
            if (!wordList.Contains(endWord))
                return res;

            List<int> lsDiffIndex = new List<int>();
            List<int> lsSameIndex = new List<int>();
            for (int i = 0; i < beginWord.Length; i++)
            {
                if (beginWord[i] != endWord[i])
                {
                    lsDiffIndex.Add(i);
                }
                else
                {
                    lsSameIndex.Add(i);
                }
            }

            DictInit(lsDiffIndex.ToArray(), endWord, lsSameIndex.ToArray(), wordList.ToArray());

            if (dictLen.Count == 0)
                return res;

            InitNextWordsDict(wordList);


            var keys = dictLen.Keys.ToList();
            int min = int.MaxValue;
            foreach (var item in keys)
            {
                min = Math.Min(item.Length, min);
            }
            List<string> path = new List<string>();
            path.Add(beginWord);

            var keyss = keys.Where(p => p.Length == min).ToList();
            AddNext(min + 1, beginWord, keyss, keys, endWord, path.ToArray(), res);

          
            return res;
        }
        private void AddNext(int len, string current, List<string> keyss, List<string> keys, string endWord, string[] path, List<IList<string>> resList)
        {
            foreach (var itemKey in keyss)
            {
                var nexts = dictLen[itemKey];
                foreach (var itemNext in nexts)
                {
                    if (!IsDiffOneChar(current, itemNext))
                    {
                        List<string> pathChild = new List<string>(path);
                        List<string[]> ress = new List<string[]>();
                        AddPath(current, itemNext, pathChild, ress);

                        if (ress.Count > 0)
                        {
                            foreach (var item in ress)
                            {
                                if (len <= endWord.Length)
                                {
                                    List<string> path1 = new List<string>(item);

                                    var keyss1 = keys.Where(p => p.Contains(itemKey) && p.Length == len).ToList();
                                    AddNext(len + 1, itemNext, keyss1, keys, endWord, path1.ToArray(), resList);
                                }
                                else
                                {
                                    var paths = item.ToList();
                                    paths.Add(endWord);
                                    AddPathRes(resList, paths);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (len <= endWord.Length)
                        {
                            List<string> pathChild = new List<string>(path);
                            pathChild.Add(itemNext);
                            var keyss1 = keys.Where(p => p.Contains(itemKey) && p.Length == len).ToList();
                            AddNext(len + 1, itemNext, keyss1, keys, endWord, pathChild.ToArray(), resList);
                        }
                        else
                        {
                            var paths = path.ToList();
                            paths.Add(endWord);

                            AddPathRes(resList, paths);

                        }
                    }

                }
            }
        }

        private void AddPathRes(List<IList<string>> resList, List<string> path)
        {

            if (resList.Count == 0)
            {
                MinCount = Math.Min(path.Count, MinCount);
                resList.Add(path);
            }
            else
            {

                if (path.Count < MinCount)
                {
                    resList.Clear();
                    resList.Add(path);
                    MinCount = path.Count;
                }
                else
                {
                    if (path.Count > MinCount)
                        return;
                    bool bl = false;
                    foreach (var item in resList)
                    {
                        if (item.SequenceEqual(path))
                        {
                            bl = true;
                            break;
                        }
                    }
                    if (bl == false)
                    {
                        resList.Add(path);
                    }
                }

            }
        }

        private void AddPath(string current, string target, List<string> list, List<string[]> res)
        {
            if (!wordDict.ContainsKey(current))
            {
                return;
            }
            var ls = wordDict[current];
            HashSet<string> set = new HashSet<string>(list);
            var ws = ls.Where(p => !set.Contains(p)).ToList();
            foreach (var word in ws)
            {
                if (IsDiffOneChar(word, target))
                {
                    list.Add(word);
                    list.Add(target);
                    res.Add(list.ToArray());
                    list.RemoveAt(list.Count - 1);
                    list.RemoveAt(list.Count - 1);
                    return;
                }
            }
            foreach (var word in ws)
            {
                list.Add(word);
                AddPath(word, target, list, res);
                list.RemoveAt(list.Count - 1);
            }

        }

        private void InitNextWordsDict(IList<string> wordList)
        {
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

                wordDict.Add(word, ls);
            }

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

        private void DictInit(int[] lsDiffIndex, string endWord, int[] lsIndexUsed, string[] words)
        {
            for (int i = 0; i < lsDiffIndex.Length; i++)
            {
                var arr = lsIndexUsed.ToList();
                int index = lsDiffIndex[i];

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
                        string key = string.Join("", arr);
                        if (!dictLen.ContainsKey(key))
                        {
                            dictLen.Add(key, new List<string>());
                        }

                        dictLen[key].Add(item);
                    }
                    else
                    {
                        listWord.Add(item);
                    }
                }
                if (listWord.Count < words.Length)
                {
                    var newArr = lsDiffIndex.Where(p => p != index).ToArray();

                    DictInit(newArr, endWord, arr.ToArray(), listWord.ToArray());
                }

            }
        }





    }
}
