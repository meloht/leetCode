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
        private Dictionary<int, HashSet<string>> dictLen = new Dictionary<int, HashSet<string>>();
        private Dictionary<string, HashSet<string>> dictWord = new Dictionary<string, HashSet<string>>();
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

            int minLen = DictInit(lsDiffIndex.ToArray(), endWord, lsSameIndex.ToArray(), wordList.ToArray());

            if (dictLen.Count == 0)
                return res;

            var wordListVal = wordList.ToList();
            bool bl = !wordListVal.Contains(beginWord);
            if (bl)
            {
                wordListVal.Add(beginWord);
            }
            InitNextWordsDict(wordListVal);

            var keys = dictLen.Keys.ToList();

            List<string> path = new List<string>();
            path.Add(beginWord);

            AddNext(minLen, beginWord, keys, endWord, path.ToArray(), res);


            return res;
        }
        private void AddNext(int len, string current, List<int> keys, string endWord, string[] path, List<IList<string>> resList)
        {
            if (path.Length >= MinCount)
                return;
            if (len > endWord.Length)
                return;
            var keysNext = keys.Where(p => p == len).ToList();
            var nexts = dictWord[current];
            var nextList = GetDictNextList(keysNext);
            var mergeList = MergePath(nexts, nextList);
            foreach (string word in mergeList)
            {
                if (nextList.Contains(word))
                {
                    if (len == endWord.Length && word == endWord)
                    {
                        var paths = path.ToList();
                        paths.Add(endWord);
                        if (paths.Count > MinCount)
                            break;
                        AddPathRes(resList, paths);
                    }
                    else
                    {
                        List<string> pathChild = new List<string>(path);
                        pathChild.Add(word);
                        if (pathChild.Count > MinCount)
                            break;
                        AddNext(len + 1, word, keys, endWord, pathChild.ToArray(), resList);
                    }

                }
                else
                {
                    foreach (var nextTarget in nextList)
                    {
                        List<string> pathChild = new List<string>(path);
                        pathChild.Add(word);
                        if (pathChild.Count > MinCount)
                            break;
                        List<string[]> ress = new List<string[]>();
                        AddPath(word, nextTarget, pathChild, ress);
                       
                        if (ress.Count > 0)
                        {
                            foreach (var item in ress)
                            {
                                if (len < endWord.Length)
                                {
                                    if (item.Length > MinCount)
                                        break;
                                    List<string> path1 = new List<string>(item);
                                    AddNext(len + 1, nextTarget, keys, endWord, path1.ToArray(), resList);
                                }
                                else
                                {
                                    if (item.Length > MinCount)
                                        break;
                                    var paths = item.ToList();
                                    if (nextTarget == endWord)
                                    {
                                        AddPathRes(resList, paths);
                                    }
                                }
                            }
                        }
                    }

                }
            }

        }

        private List<string> MergePath(HashSet<string> nexts, HashSet<string> targetList)
        {
            List<string> listTarget = new List<string>();
            List<string> list = new List<string>();
            foreach (var item in nexts)
            {
                list.Add(item);
                if (targetList.Contains(item))
                {
                    listTarget.Add(item);
                }
            }
            if (listTarget.Count > 0)
                return listTarget;

            return list;
        }
        private HashSet<string> GetDictNextList(List<int> keys)
        {
            HashSet<string> res = null;
            foreach (int key in keys)
            {
                var ls = dictLen[key];
                if (res == null)
                {
                    res = ls;
                }
                else
                {
                    foreach (var item in ls)
                    {
                        if (!res.Contains(item))
                        {
                            res.Add(item);
                        }
                    }
                }

            }
            return res;
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
            if (list.Count >= MinCount)
            {
                return;
            }
            if (!dictWord.ContainsKey(current))
            {
                return;
            }
            if (res.Count > 0)
            {
                return;
            }
            var ls = dictWord[current];

            HashSet<string> set = new HashSet<string>(list);
            var wordList = ls.Where(p => !set.Contains(p)).ToList();

            var words = wordList.Where(p => p == target).ToList();
            if (words.Count > 0)
            {
                List<string> path = new List<string>(list);
                path.Add(target);
                res.Add(path.ToArray());
                return;
            }

            foreach (var word in wordList)
            {
                if (IsDiffOneChar(word, target))
                {
                    var path = new List<string>(list);
                    path.Add(word);
                    path.Add(target);
                    res.Add(path.ToArray());

                    return;
                }

            }

            if (res.Count > 0)
            {
                return;
            }
            if (list.Count >= MinCount)
            {
                return;
            }
            foreach (var word in wordList)
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
                HashSet<string> ls = new HashSet<string>();
                for (int i = 0; i < word.Length; i++)
                {
                    foreach (var item in wordList)
                    {
                        if (item == word)
                            continue;
                        if (IsDiffOneChar(item, word, i) && !ls.Contains(item))
                        {
                            ls.Add(item);
                        }
                    }
                }

                dictWord.Add(word, ls);
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

        private int DictInit(int[] lsDiffIndex, string endWord, int[] lsIndexUsed, string[] words)
        {
            int minLen = int.MaxValue;
            for (int i = 0; i < lsDiffIndex.Length; i++)
            {
                var arr = lsIndexUsed.ToList();
                int index = lsDiffIndex[i];

                arr.Add(index);
                HashSet<int> list = new HashSet<int>(arr);
                HashSet<string> listWord = new HashSet<string>();
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
                        minLen = Math.Min(minLen, arr.Count);
                        if (!dictLen.ContainsKey(arr.Count))
                        {
                            dictLen.Add(arr.Count, new HashSet<string>());
                        }
                        var set = dictLen[arr.Count];
                        if (!set.Contains(item))
                        {
                            set.Add(item);
                        }
                    }
                    else
                    {
                        listWord.Add(item);
                    }
                }
                if (listWord.Count < words.Length)
                {
                    var newArr = lsDiffIndex.Where(p => p != index).ToArray();

                    int min = DictInit(newArr, endWord, arr.ToArray(), listWord.ToArray());
                    minLen = Math.Min(min, minLen);
                }

            }
            return minLen;
        }





    }
}
