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
        private Dictionary<int, List<string>> dictLen = new Dictionary<int, List<string>>();
        private Dictionary<string, HashSet<string>> dictWord = new Dictionary<string, HashSet<string>>();

        private int MinCount = int.MaxValue;
        int numLen = int.MaxValue;
        public IList<IList<string>> FindLadders1(string beginWord, string endWord, IList<string> wordList)
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
            var words = wordList.ToList();

            int minLen = DictInit(lsDiffIndex.ToArray(), endWord, lsSameIndex.ToArray(), words.ToArray());

            if (dictLen.Count == 0)
                return res;

            bool bl = !words.Contains(beginWord);
            if (bl)
            {
                words.Add(beginWord);
            }
            HashSet<string> wordSet = new HashSet<string>(words);
            List<string> path = new List<string>();
            path.Add(beginWord);

            AddNext(minLen, beginWord, endWord, path.ToArray(), res, wordSet);

            return res;
        }
        private void AddNext(int len, string current, string endWord, string[] path, List<IList<string>> resList, HashSet<string> wordList)
        {
            if (path.Length >= MinCount)
                return;
            if (len > endWord.Length)
                return;

            var nextList = dictLen[len];
            foreach (var target in nextList)
            {
                numLen = int.MaxValue;
                string key = $"{current}-{target}";
                if (MinCount != int.MaxValue)
                {
                    numLen = MinCount - path.Length - (endWord.Length - len);
                }
                List<List<string>> nextPath = new List<List<string>>();
                AddToTargetPathBfs(current, target, nextPath, numLen, wordList);


                foreach (var item in nextPath)
                {
                    List<string> pathList = new List<string>(path);
                    pathList.AddRange(item);
                    if (len < endWord.Length)
                    {
                        if (pathList.Count > MinCount)
                            break;

                        AddNext(len + 1, target, endWord, pathList.ToArray(), resList, wordList);
                    }
                    else
                    {
                        if (pathList.Count > MinCount)
                            break;
                        var paths = pathList.ToList();
                        if (target == endWord)
                        {
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

        private HashSet<string> GetNextWordList(string word, HashSet<string> wordList)
        {
            if (dictWord.ContainsKey(word))
            {
                return dictWord[word];
            }
            char[] charArray = word.ToArray();
            HashSet<string> ls = new HashSet<string>();
            for (int i = 0; i < word.Length; i++)
            {
                char curr = word[i];
                for (char j = 'a'; j <= 'z'; j++)
                {
                    if (j != curr)
                    {
                        charArray[i] = j;
                        string ss = new string(charArray);
                        if (wordList.Contains(ss))
                        {
                            ls.Add(ss);
                        }

                    }
                }
                charArray[i] = curr;

            }

            dictWord.Add(word, ls);
            return ls;
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
                        minLen = Math.Min(minLen, arr.Count);
                        if (!dictLen.ContainsKey(arr.Count))
                        {
                            dictLen.Add(arr.Count, new List<string>());
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

        private void AddToTargetPathBfs(string current, string target, List<List<string>> res, int numLen, HashSet<string> wordList)
        {
            Queue<NodeData> queue = new Queue<NodeData>();
            NodeData nodeFirst = new NodeData();
            nodeFirst.word = current;
            HashSet<string> used = new HashSet<string>();
            used.Add(current);
            queue.Enqueue(nodeFirst);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    var next = GetNextWordList(node.word, wordList);

                    if (next.Contains(target))
                    {
                        node.PathList.Add(target);
                        if (node.PathList.Count < numLen)
                        {
                            res.Clear();
                            numLen = node.PathList.Count;
                            res.Add(node.PathList);
                        }
                        else if (node.PathList.Count == numLen)
                        {
                            res.Add(node.PathList);
                        }

                    }
                    else
                    {
                        var words = next.Where(p => !used.Contains(p)).ToList();

                        foreach (var item in words)
                        {
                            NodeData nodeNext = new NodeData();
                            nodeNext.PathList.AddRange(node.PathList);
                            nodeNext.word = item;
                            nodeNext.PathList.Add(item);
                            if (nodeNext.PathList.Count < numLen)
                            {
                                queue.Enqueue(nodeNext);
                            }
                            used.Add(item);
                        }
                    }



                }
            }
        }
        class NodeData
        {
            public string word;
            public List<string> PathList = new List<string>();
            public override string ToString()
            {
                return word;
            }
        }

        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            List<IList<string>> res = new List<IList<string>>();
            HashSet<string> wordSets = new HashSet<string>(wordList);
            if (!wordSets.Contains(endWord))
                return res;

            wordSets.Remove(beginWord);

            Dictionary<string, int> steps = new Dictionary<string, int>();
            steps.Add(beginWord, 0);
            Dictionary<string, List<string>> from = new Dictionary<string, List<string>>();
            int step = 1;
            bool found = false;
            int wordlen = beginWord.Length;
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    string current = queue.Dequeue();
                    char[] charArr = current.ToArray();
                    for (int j = 0; j < wordlen; j++)
                    {
                        char origin = charArr[j];
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            charArr[j] = c;

                            string nextWord = new string(charArr);
                          
                            if (steps.ContainsKey(nextWord) && step == steps[nextWord])
                            {
                                from[nextWord].Add(current);
                            }
                            if (!wordSets.Contains(nextWord))
                            {
                                continue;
                            }
                            wordSets.Remove(nextWord);
                            queue.Enqueue(nextWord);


                            from.TryAdd(nextWord, new List<string>());
                            from[nextWord].Add(current);

                            steps.Add(nextWord, step);

                            if (nextWord == endWord)
                            {
                                found = true;
                            }
                        }
                        charArr[j] = origin;
                    }



                }
                step++;
                if (found)
                {
                    break;
                }
            }
            if (found)
            {
                List<string> path = new List<string>();
                path.Add(endWord);
                BackTrack(from, path, beginWord, endWord, res);
            }

            return res;
        }

        private void BackTrack(Dictionary<string, List<string>> from, List<string> path, string beginword, string cur, List<IList<string>> res)
        {
            if (cur == beginword)
            {
                res.Add(new List<string>(path));
                return;
            }
            
            var list = from[cur];
            foreach (string precursor in list)
            {
                path.Insert(0,precursor);
                BackTrack(from, path, beginword, precursor, res);
                path.RemoveAt(0);
            }

        }
    }
}
