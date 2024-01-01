using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0378
{
    public class Alg_378_04
    {
        public bool[] CanMakePalindromeQueries(string s, int[][] queries)
        {
            int len = s.Length / 2;
            string begin = s.Substring(0, len);
            string end = s.Substring(len);
            bool[] res = new bool[queries.Length];

            var dict1 = GetCharDict(begin);
            var dict2 = GetCharDict(end);

            if (dict1.SequenceEqual(dict2) == false)
                return res;

            int[][] dictLeft = InitCacheData(begin, dict1);
            int[][] dictRight = InitCacheData(end, dict2);

            Dictionary<string, bool> dict = new Dictionary<string, bool>();

            for (int i = 0; i < queries.Length; i++)
            {
                string key = string.Join(",", queries[i]);
                if (dict.ContainsKey(key))
                {
                    res[i] = dict[key];
                }
                else
                {
                    res[i] = IsSame(begin, end, queries[i], len, dictLeft, dictRight);
                    dict.Add(key, res[i]);
                }
            }

            return res;
        }

        private bool IsSame(string begin, string end, int[] arr, int len, int[][] dictLeft, int[][] dictRight)
        {
            int a = arr[0];
            int b = arr[1];
            int c = arr[2];
            int d = arr[3];

            int c1 = 2 * len - (d + 1);
            int d1 = 2 * len - (c + 1);

            var dict1 = GetCharArr(dictLeft, a, b);
            var dict2 = GetCharArr(dictRight, c - len, d - len);

            int leftMax = Math.Max(a, c1);
            int baseIndex = len - 1;
            for (int i = 0; i < leftMax; i++)
            {
                int j = baseIndex - i;
                if (i >= a && i <= b)
                {
                    if (!ReduceDict(dict1, end[j]))
                    {
                        return false;
                    }
                }
                else if (i >= c1 && i <= d1)
                {
                    if (!ReduceDict(dict2, begin[i]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (begin[i] != end[j])
                        return false;
                }
            }

            int rightMax = Math.Min(b, d1) + 1;
            for (int i = rightMax; i < len; i++)
            {
                int j = baseIndex - i;
                if (i >= a && i <= b)
                {
                    if (!ReduceDict(dict1, end[j]))
                    {
                        return false;
                    }
                }
                else if (i >= c1 && i <= d1)
                {
                    if (!ReduceDict(dict2, begin[i]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (begin[i] != end[j])
                        return false;
                }
            }
            if (dict1.SequenceEqual(dict2))
                return true;


            return false;
        }

        private int[][] InitCacheData(string s, int[] dictAll)
        {
            int[][] dict = new int[s.Length][];

            dict[s.Length - 1] = dictAll;
            for (int i = s.Length - 2; i >= 0; i--)
            {
                var ch = s[i + 1] - 'a';
                int[] arr = new int[26];
                Array.Copy(dict[i + 1], arr, 26);
                arr[ch]--;
                dict[i] = arr;
            }

            return dict;
        }


        private bool ReduceDict(int[] dict, char item)
        {
            int index = item - 'a';
            if (dict[index] > 0)
            {
                dict[index]--;
                return true;
            }
            else
            {
                return false;
            }

        }

        private int[] GetCharArr(int[][] dict, int begin, int end)
        {
            int[] arr = new int[26];
            var range1 = dict[end];

            for (int i = 0; i < 26; i++)
            {
                arr[i] = range1[i];
            }
            if (begin > 0)
            {
                var range2 = dict[begin - 1];
                for (int i = 0; i < 26; i++)
                {
                    arr[i] = arr[i] - range2[i];
                }
            }
            return arr;
        }

        private int[] GetCharDict(string begin)
        {
            int[] arr = new int[26];
            foreach (char c in begin)
            {
                int index = c - 'a';
                arr[index]++;

            }
            return arr;
        }

    }
}
