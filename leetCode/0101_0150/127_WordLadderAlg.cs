using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _127_WordLadderAlg
    {

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> wordSets = new HashSet<string>(wordList);
            if (!wordSets.Contains(endWord))
                return 0;

            wordSets.Remove(beginWord);

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

                            if (!wordSets.Contains(nextWord))
                            {
                                continue;
                            }
                            wordSets.Remove(nextWord);
                            queue.Enqueue(nextWord);

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
                return step;
            }

            return 0;
        }

       

    }
}
