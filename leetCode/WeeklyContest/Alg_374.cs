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
            Dictionary<char, int> dict = new Dictionary<char, int>();

            List<char> list = new List<char>();
            Dictionary<int, List<string>> dictSubWord = new Dictionary<int, List<string>>();
            List<Node> listIndex = new List<Node>();

            int index = 0;
            int wordCount = 0;
            while (index < word.Length)
            {
                int i = index;

                while (i < word.Length)
                {
                    var ch = word[i];
                    if (list.Count > 0)
                    {
                        var chlast = list[list.Count - 1];
                        if (Math.Abs(ch - chlast) > 2)
                        {
                            ComputeCount(listIndex, word, dictSubWord);
                            list.Clear();
                            dict.Clear();
                            listIndex.Clear();
                            wordCount = 0;
                            index = i;
                            break;
                        }
                        else
                        {
                            list.Add(ch);
                            AddCount(ch, dict);
                            wordCount++;
                            if (dict[ch] == k)
                            {
                                if (CheckWord(dict, list, k))
                                {
                                    int start = i - (wordCount - 1);
                                    listIndex.Add(new Node(start, wordCount));
                                    wordCount = 0;
                                }
                            }
                            else
                            {
                                if (dict[ch] > k)
                                {
                                    ComputeCount(listIndex, word, dictSubWord);
                                    listIndex.Clear();
                                    if (i == word.Length - 1)
                                    {
                                        int nn = GetLastIndex(dict, k, list);
                                        if (nn > -1)
                                        {
                                            index = index + nn;
                                            list.Clear();
                                            dict.Clear();
                                            wordCount = 0;
                                            i = index;
                                            break;
                                        }
                                    }
                                    int firstIndex = list.IndexOf(ch);
                                    index = index + firstIndex + 1;
                                    list.Clear();
                                    dict.Clear();

                                    wordCount = 0;
                                    break;

                                }
                            }
                        }
                    }
                    else
                    {
                        list.Add(word[i]);
                        AddCount(ch, dict);
                        wordCount++;
                        if (dict[ch] == k)
                        {
                            if (CheckWord(dict, list, k))
                            {
                                int start = i - (wordCount - 1);
                                listIndex.Add(new Node(start, wordCount));
                                wordCount = 0;
                            }
                        }
                    }

                    i++;

                }
                if (i == word.Length)
                {
                    if (list.Count > 0)
                    {
                        if (listIndex.Count > 0)
                        {
                            ComputeCount(listIndex, word, dictSubWord);
                            var node = listIndex[listIndex.Count - 1];
                            int num = node.Index + node.Length;
                            listIndex.Clear();

                            if (num == word.Length)
                            {
                                break;
                            }
                            else
                            {
                                index = num;
                               
                            }

                        }
                        else
                        {
                            if (!CheckWord(dict, list, k) && list.Count == k)
                            {
                                break;
                            }

                            int nn = GetLastIndex(dict, k, list);
                            if (nn > -1)
                            {
                                index = index + nn;
                            }
                           
                            list.Clear();
                            dict.Clear();
                            wordCount = 0;
                            if (index < 0)
                            {
                                break;
                            }
                        }

                    }
                    else
                    {
                        break;
                    }
                    if (word.Length - index < k)
                        break;
                }
            }

            int count = 0;
            foreach (var item in dictSubWord)
            {
                count += item.Value.Count;
            }

            return count;
        }


        private int GetLastIndex(Dictionary<char, int> dict, int k, List<char> list)
        {
            int lastIndex = -1;
            foreach (var item in dict)
            {
                if (item.Value < k)
                {
                    lastIndex = list.IndexOf(item.Key) + item.Value;
                    break;
                }
            }
            if (lastIndex == -1)
                return lastIndex;
            var arr = list.GetRange(lastIndex, list.Count - lastIndex);
            List<char> ls = new List<char>();
            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    if (dict[item] > 0)
                    {
                        dict[item]--;
                    }
                    if (dict[item] == 0)
                    {
                        ls.Add(item);
                    }
                }
            }
            foreach (var item in ls)
            {
                dict.Remove(item);
            }

            return lastIndex;
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

        private void ComputeCount(List<Node> listIndex, string word, Dictionary<int, List<string>> dictSubWord)
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

        private void AddAns(Dictionary<int, List<string>> dictSubWord, int index, string sub)
        {
            if (!dictSubWord.ContainsKey(index))
            {
                dictSubWord.Add(index, new List<string>());
            }
            if (!dictSubWord[index].Contains(sub))
            {
                dictSubWord[index].Add(sub);
            }

        }

        private void AddCount(char ss, Dictionary<char, int> dict)
        {
            if (!dict.ContainsKey(ss))
            {
                dict.Add(ss, 0);
            }
            dict[ss]++;
        }

        private bool CheckWord(Dictionary<char, int> dict, List<char> list, int k)
        {

            foreach (var item in list)
            {
                if (!dict.ContainsKey(item))
                    return false;

                if (dict[item] != k)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
