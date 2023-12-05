using System;
using System.Collections;
using System.Collections.Generic;
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

            Dictionary<int, Dictionary<int, char[]>> dictSubWord = new Dictionary<int, Dictionary<int, char[]>>();
            List<char> list = new List<char>();
           
            int count = 0;
            int i = 0;
            int currentLen = k;
            int end = currentLen;

            while (currentLen <= word.Length)
            {
                while (i < end && i < word.Length)
                {
                    if (i == 0 || CheckWord(dict, list, k))
                    {
                        if (dictSubWord.ContainsKey(i))
                        {
                            
                        }
                    }

                    var ss = word[i];
                    list.Add(ss);
                    if (!dict.ContainsKey(ss))
                    {
                        dict.Add(ss, 0);
                    }
                    dict[ss]++;

                    if (i == end - 1)
                    {
                        if (CheckWord(dict, list, k))
                        {
                            int start = i - (currentLen - 1);
                            AddRes(dictSubWord, start, list.ToArray());
                        }
                        var first = list[0];
                        SubtractCharDict(first, dict);
                        list.RemoveAt(0);

                        end++;
                    }
                    i++;
                }
                while (list.Count >= currentLen)
                {
                    var first = list[0];
                    SubtractCharDict(first, dict);
                    list.RemoveAt(0);
                    if (CheckWord(dict, list, k))
                    {
                        int start = i - (currentLen - 1);
                        AddRes(dictSubWord, start, list.ToArray());
                    }
                }
                list.Clear();
                currentLen += k;
                i = 0;
                end = currentLen;
            }

            foreach (var item in dictSubWord)
            {
                count += item.Value.Count;
            }
            return count;
        }

        private void SubtractCharDict(char ss, Dictionary<char, int> dict)
        {
            if (dict.ContainsKey(ss))
            {
                if (dict[ss] > 0)
                {
                    dict[ss]--;
                }
            }
        }
        private void AddCount(char[] ss, Dictionary<char, int> dict)
        {
            foreach (var item in ss)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }
                dict[item]++;
            }
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
        private void AddRes(Dictionary<int, Dictionary<int, char[]>> dictSubWord, int index, char[] arr)
        {
            if (!dictSubWord.ContainsKey(index))
            {
                dictSubWord.Add(index, new Dictionary<int, char[]>());
            }
            if (!dictSubWord[index].ContainsKey(arr.Length))
            {
                dictSubWord[index].Add(arr.Length, arr);
            }
        }

        private bool Compute(List<char> list, Dictionary<char, int> dict)
        {
            bool bl = true; ;
            foreach (char j in list)
            {
                if (dict[j] != 2)
                {
                    bl = false;
                }
            }
            return bl;
        }
        class NodeS
        {
            public char word;
            public int Index;
            public int Count;
        }
    }
}
