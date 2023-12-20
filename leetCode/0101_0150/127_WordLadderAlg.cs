using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int stepBegin = 1;
            int stepEnd = 1;

            int wordlen = beginWord.Length;

            wordSets.Remove(beginWord);
            wordSets.Remove(endWord);

            Queue<string> queueBegin = new Queue<string>();
            Queue<string> queueEnd = new Queue<string>();
            queueBegin.Enqueue(beginWord);
            queueEnd.Enqueue(endWord);

            HashSet<string> nextList1 = new HashSet<string>();
            HashSet<string> nextList2 = new HashSet<string>();
            nextList2.Add(endWord);
            nextList1.Add(beginWord);

            while (queueBegin.Count > 0 || queueEnd.Count > 0)
            {
                int countBegin = queueBegin.Count;

                for (int i = 0; i < countBegin; i++)
                {
                    string current = queueBegin.Dequeue();
                    char[] charArr = current.ToArray();

                    for (int j = 0; j < wordlen; j++)
                    {
                        char origin = charArr[j];
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            charArr[j] = c;

                            string nextWord = new string(charArr);

                            if (!wordSets.Contains(nextWord) && !nextList2.Contains(nextWord))
                            {
                                continue;
                            }
                            if (wordSets.Contains(nextWord))
                            {
                                wordSets.Remove(nextWord);
                            }
                            if (nextList2.Contains(nextWord))
                            {
                                return stepBegin + stepEnd;
                            }
                            queueBegin.Enqueue(nextWord);
                            nextList1.Add(nextWord);
                        }
                        charArr[j] = origin;
                    }

                }

                nextList2.Clear();
                int countEnd = queueEnd.Count;

                for (int i = 0; i < countEnd; i++)
                {
                    string current = queueEnd.Dequeue();
                    char[] charArr = current.ToArray();
                    for (int j = 0; j < wordlen; j++)
                    {
                        char origin = charArr[j];
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            charArr[j] = c;

                            string nextWord = new string(charArr);

                            if (!wordSets.Contains(nextWord) && !nextList1.Contains(nextWord))
                            {
                                continue;
                            }
                            if (wordSets.Contains(nextWord))
                            {
                                wordSets.Remove(nextWord);
                            }

                            if (nextList1.Contains(nextWord))
                            {
                                return stepBegin + stepEnd + 1;
                            }
                            nextList2.Add(nextWord);
                            queueEnd.Enqueue(nextWord);
                        }
                        charArr[j] = origin;
                    }
                }
                nextList1.Clear();
                stepEnd++;
                stepBegin++;
            }


            return 0;
        }




    }
}
