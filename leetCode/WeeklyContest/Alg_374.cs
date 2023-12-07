using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest
{
    public class Alg_374
    {
        public IList<int> FindPeaks(int[] mountain)
        {
            List<int> peak = new List<int>();


            for (int i = 1; i < mountain.Length - 1; i++)
            {
                int pre = mountain[i - 1];
                int num = mountain[i];
                int next = mountain[i + 1];
                if (num > pre && num > next)
                {
                    peak.Add(i);
                }
            }

            return peak;
        }

        public int MinimumAddedCoins(int[] coins, int target)
        {
            Array.Sort(coins);
            int count = 0;
            int index = 0;
            List<int> list = new List<int>();
            for (int i = 1; i <= target; i++)
            {
                int tt = i;
                for (int j = 0; j <= coins.Length - 1; j++)
                {
                    int num = coins[j];
                    if (num <= tt)
                    {
                        tt -= num;
                    }
                }
                if (tt > 0)
                {
                    list.Add(i);
                }
            }
            return count;
        }

        private List<List<int>> GetAllList(int[] coins)
        {
            List<List<int>> result = new List<List<int>>();
            GenerateSubsequences(coins, 0, new List<int>(), result);
            return result;
        }


        private void GenerateSubsequences(int[] arr, int index, List<int> current, List<List<int>> result)
        {
            if (index == arr.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            GenerateSubsequences(arr, index + 1, current, result);

            current.Add(arr[index]);
            GenerateSubsequences(arr, index + 1, current, result);
            current.RemoveAt(current.Count - 1);
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
                int num = GetWordNum(item, k);
                count += num;
            }
            return count;
        }

        private int GetWordNum(string word, int k)
        {
            if (word.Length < k)
                return 0;

            int end = k;
            int index = 0;
            Dictionary<int, Node> dictWordLen = new Dictionary<int, Node>();
            List<Node> listNode = new List<Node>();
            int windex = 0;
            for (int i = 1; i < word.Length; i++)
            {
                var chpre = word[i - 1];
                var chcurr = word[i];
                if (chcurr == chpre)
                {
                    if (!dictWordLen.ContainsKey(windex))
                    {
                        dictWordLen.Add(windex, new Node(windex, chpre, 1));
                        listNode.Add(dictWordLen[windex]);
                    }
                    dictWordLen[windex].Add(1);
                }
                else
                {
                    windex = i;
                }
            }


            List<char> list = new List<char>();
            List<char[]> listRes = new List<char[]>();
            Dictionary<int, char[]> dictAns = new Dictionary<int, char[]>();
            Dictionary<int, Dictionary<char, int>> dictAnsNums = new Dictionary<int, Dictionary<char, int>>();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int step = k; step <= word.Length; step += k)
            {
                index = 0;
                end = step;
                while (end <= word.Length)
                {
                    list.Clear();
                    dict.Clear();
                    int begin = index;
                    while (begin < end)
                    {
                        if (dictAns.ContainsKey(begin))
                        {
                            list.AddRange(dictAns[begin]);
                            var dictTemp = dictAnsNums[begin];
                            foreach (var item in dictTemp)
                            {
                                if (!dict.ContainsKey(item.Key))
                                {
                                    dict.Add(item.Key, 0);
                                }
                                dict[item.Key] += item.Value;
                            }
                            begin = begin + dictAns[begin].Length;
                        }
                        else
                        {
                            break;
                        }
                    }
                    int j = begin;
                   

                    while (j < end)
                    {
                        var ch = word[j];

                        if (list.Count > 0)
                        {
                            var chlast = list[list.Count - 1];
                            if (Math.Abs(ch - chlast) > 2)
                            {
                                break;
                            }
                            list.Add(ch);
                            AddCount(ch, dict, 1);
                        }
                        else
                        {
                            var node = listNode.Where(p => j >= p.Index && j < p.EndIndex).FirstOrDefault();
                            if (node != null)
                            {
                                int nn = node.EndIndex - j;
                                if (nn < step)
                                {
                                    for (int i = 0; i < nn; i++)
                                    {
                                        list.Add(ch);
                                    }
                                    AddCount(ch, dict, nn);
                                    j = j + nn - 1;
                                    if (dict[ch] > k)
                                    {
                                        break;
                                    }
                                    continue;
                                }
                                else
                                {
                                    for (int i = 0; i < step; i++)
                                    {
                                        list.Add(ch);
                                    }
                                    AddCount(ch, dict, step);
                                    break;
                                }
                            }
                            else
                            {
                                list.Add(ch);
                                AddCount(ch, dict, 1);
                            }

                        }
                        if (dict[ch] > k)
                        {
                            break;
                        }

                        j++;
                    }

                    if (list.Count == step && CheckWord(dict, k))
                    {
                        if (dictAns.ContainsKey(index))
                        {
                            dictAns.Remove(index);
                        }
                        if (dictAnsNums.ContainsKey(index))
                        {
                            dictAnsNums.Remove(index);
                        }
                        dictAns.Add(index, list.ToArray());
                        dictAnsNums.Add(index, new Dictionary<char, int>(dict));
                        listRes.Add(list.ToArray());
                    }

                    index++;
                    end++;

                }
            }

            return listRes.Count;
        }



        private void AddCount(char ss, Dictionary<char, int> dict, int count)
        {
            if (!dict.ContainsKey(ss))
            {
                dict.Add(ss, 0);
            }
            dict[ss] += count;
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
            public int Index;
            public int EndIndex;
            public char Word;
            public int Count;
            public void Add(int num)
            {
                Count += num;
                EndIndex = Index + Count;
            }

            public Node(int index, char word, int count)
            {
                this.Index = index;
                this.Word = word;
                this.Count = count;
            }
            public override string ToString()
            {
                return $"{Index} {Word} {Count}";
            }
        }

    }
}
