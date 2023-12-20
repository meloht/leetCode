using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0101_0150
{
    public class _127_WordLadderAlg
    {

        public int LadderLength1(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> wordSets = new HashSet<string>(wordList);
            if (!wordSets.Contains(endWord))
                return 0;

            wordSets.Remove(beginWord);

            int step = 1;
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

                            if (!wordSets.Contains(nextWord))
                            {
                                continue;
                            }
                            wordSets.Remove(nextWord);
                            queue.Enqueue(nextWord);

                            if (nextWord == endWord)
                            {
                                return step + 1;
                            }
                        }
                        charArr[j] = origin;

                    }

                }
                step++;

            }

            return 0;
        }

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> wordSets = new HashSet<string>(wordList);
            if (!wordSets.Contains(endWord))
                return 0;

            int wordlen = beginWord.Length;

            wordSets.Remove(beginWord);
            wordSets.Remove(endWord);

            Queue<string> queueBegin = new Queue<string>();
            Queue<string> queueEnd = new Queue<string>();
            queueBegin.Enqueue(beginWord);
            queueEnd.Enqueue(endWord);

            HashSet<string> nextListBegin = new HashSet<string>();
            HashSet<string> nextListEnd = new HashSet<string>();
            nextListEnd.Add(endWord);
            nextListBegin.Add(beginWord);
            int step = 2;

            while (queueBegin.Count > 0 || queueEnd.Count > 0)
            {
                HashSet<string> setQueue;
                HashSet<string> setTarget;
                Queue<string> queue;
                int countBegin = queueBegin.Count;
                int countEnd = queueEnd.Count;
                if (countBegin > 0 && countEnd > 0)
                {
                    if (countBegin > countEnd)
                    {
                        setQueue = nextListEnd;
                        setTarget = nextListBegin;
                        queue = queueEnd;
                    }
                    else
                    {
                        setQueue = nextListBegin;
                        setTarget = nextListEnd;
                        queue = queueBegin;
                       
                    }
                }
                else
                {
                    if (countEnd > 0)
                    {
                        setQueue = nextListEnd;
                        setTarget = nextListBegin;
                        queue = queueEnd;
                       
                    }
                    else
                    {
                        setQueue = nextListBegin;
                        setTarget = nextListEnd;
                        queue = queueBegin;
                      
                    }
                }
                bool bl = IsFind(queue, wordlen, wordSets, setQueue, setTarget);
                if (bl)
                {
                    return step;
                }

                step++;

            }
            return 0;
        }
        private bool IsFind(Queue<string> queue, int wordlen, HashSet<string> wordSets, HashSet<string> nextListQueue, HashSet<string> nextListTarget)
        {
            int countBegin = queue.Count;

            for (int i = 0; i < countBegin; i++)
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
                        if (nextListTarget.Contains(nextWord))
                        {
                            return true;
                        }
                        if (!wordSets.Contains(nextWord))
                        {
                            continue;
                        }
                        if (wordSets.Contains(nextWord))
                        {
                            wordSets.Remove(nextWord);
                        }

                        queue.Enqueue(nextWord);
                        nextListQueue.Add(nextWord);
                    }
                    charArr[j] = origin;
                }

            }
            return false;
        }


        public int LadderLength3(string beginWord, string endWord, IList<string> wordList)
        {
            var wordSet = new HashSet<string>(wordList);
            if (!wordSet.Contains(endWord))
            {
                return 0;
            }

            var beginSet = new HashSet<string> { beginWord };
            var endSet = new HashSet<string> { endWord };

            int level = 1;
            while (beginSet.Count > 0 && endSet.Count > 0)
            {
                // 优化：每次扩展节点数较少的一方
                if (beginSet.Count > endSet.Count)
                {
                    var temp = beginSet;
                    beginSet = endSet;
                    endSet = temp;
                }

                var nextLevelSet = new HashSet<string>();
                foreach (var word in beginSet)
                {
                    var charArray = word.ToCharArray();

                    for (int j = 0; j < charArray.Length; j++)
                    {
                        char originalChar = charArray[j];

                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            if (c == originalChar) continue;

                            charArray[j] = c;
                            string nextWord = new string(charArray);

                            if (endSet.Contains(nextWord))
                            {
                                return level + 1;
                            }

                            if (wordSet.Contains(nextWord))
                            {
                                nextLevelSet.Add(nextWord);
                                wordSet.Remove(nextWord);
                            }
                        }
                        charArray[j] = originalChar;
                    }
                }

                beginSet = nextLevelSet;
                level++;
            }

            return 0;
        }


        Dictionary<string, int> wordId = new Dictionary<string, int>();
        List<List<int>> edge = new List<List<int>>();
        int nodeNum = 0;

        public int LadderLength4(string beginWord, string endWord, IList<string> wordList)
        {
            foreach (string word in wordList)
            {
                AddEdge(word);
            }
            AddEdge(beginWord);
            if (!wordId.ContainsKey(endWord))
            {
                return 0;
            }

            int[] disBegin = new int[nodeNum];
            Array.Fill(disBegin, int.MaxValue);
            int beginId = wordId[beginWord];
            disBegin[beginId] = 0;
            Queue<int> queBegin = new Queue<int>();
            queBegin.Enqueue(beginId);

            int[] disEnd = new int[nodeNum];
            Array.Fill(disEnd, int.MaxValue);
            int endId = wordId[endWord];
            disEnd[endId] = 0;
            Queue<int> queEnd = new Queue<int>();
            queEnd.Enqueue(endId);

            while (queBegin.Count > 0 && queEnd.Count > 0)
            {
                int queBeginSize = queBegin.Count;
                for (int i = 0; i < queBeginSize; ++i)
                {
                    int nodeBegin = queBegin.Dequeue();
                    if (disEnd[nodeBegin] != int.MaxValue)
                    {
                        return (disBegin[nodeBegin] + disEnd[nodeBegin]) / 2 + 1;
                    }
                    var ls = edge[nodeBegin];
                    foreach (int it in ls)
                    {
                        if (disBegin[it] == int.MaxValue)
                        {
                            disBegin[it] = disBegin[nodeBegin] + 1;
                            queBegin.Enqueue(it);
                        }
                    }
                }

                int queEndSize = queEnd.Count;
                for (int i = 0; i < queEndSize; ++i)
                {
                    int nodeEnd = queEnd.Dequeue();
                    if (disBegin[nodeEnd] != int.MaxValue)
                    {
                        return (disBegin[nodeEnd] + disEnd[nodeEnd]) / 2 + 1;
                    }
                    var ls = edge[nodeEnd];
                    foreach (int it in ls)
                    {
                        if (disEnd[it] == int.MaxValue)
                        {
                            disEnd[it] = disEnd[nodeEnd] + 1;
                            queEnd.Enqueue(it);
                        }
                    }
                }
            }
            return 0;
        }

        public void AddEdge(string word)
        {
            AddWord(word);
            int id1 = wordId[word];
            char[] array = word.ToCharArray();
            int length = array.Length;
            for (int i = 0; i < length; ++i)
            {
                char tmp = array[i];
                array[i] = '*';
                string newWord = new string(array);
                AddWord(newWord);
                int id2 = wordId[newWord];
                edge[id1].Add(id2);
                edge[id2].Add(id1);
                array[i] = tmp;
            }
        }

        public void AddWord(string word)
        {
            if (!wordId.ContainsKey(word))
            {
                wordId.Add(word, nodeNum++);
                edge.Add(new List<int>());
            }
        }



    }
}
