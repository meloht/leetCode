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

            if (IsSameStr(begin, end) == false)
                return res;
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
                    res[i] = IsSame(s, queries[i], len);
                    dict.Add(key, res[i]);
                }

            }

            return res;
        }


        private bool IsSame(string s, int[] arr, int len)
        {
            int a = arr[0];
            int b = arr[1];
            int c = arr[2];
            int d = arr[3];

            string a2 = s.Substring(a, b - a + 1);
            string b2 = s.Substring(c, d - c + 1);

            var dict2 = GetCharDict(b2);
            var dict1 = GetCharDict(a2);

            for (int i = 0, j = s.Length - 1; i < len; i++, j--)
            {
                if (i >= a && i <= b)
                {
                    if (j >= c && j <= d)
                    {
                    }
                    else
                    {
                        if (!ReduceDict(dict1, s[j]))
                        {
                            return false;
                        }
                    }
                }
                else
                {

                    if (j >= c && j <= d)
                    {
                        if (!ReduceDict(dict2, s[i]))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (s[i] != s[j])
                            return false;
                    }
                }
            }
            if (IsSameDict(dict1, dict2))
                return true;


            return false;
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

        private bool IsSameStr(string s1, string s2)
        {
            if (s1 == s2)
                return true;

            var dict1 = GetCharDict(s1);
            var dict2 = GetCharDict(s2);

            if (IsSameDict(dict1, dict2))
                return true;
            return false;
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
        private bool IsSameDict(int[] dict1, int[] dict2)
        {
            if (dict1.SequenceEqual(dict2))
            {
                return true;
            }
            return false;
          
        }
    }
}
