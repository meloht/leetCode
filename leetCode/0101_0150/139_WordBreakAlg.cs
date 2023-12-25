using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _139_WordBreakAlg
    {
        public bool WordBreak1(string s, IList<string> wordDict)
        {
            HashSet<string> wordSet = new HashSet<string>(wordDict);
            int[,] dp = new int[s.Length, s.Length];

            if (wordSet.Contains(s))
                return true;
            if (!IsStop(s, 0, s.Length - 1, dp, wordSet))
            {
                return false;
            }
            for (int i = 1; i < s.Length; i++)
            {
                bool bl1 = Dfs(s, 0, i - 1, dp, wordSet);
                bool bl2 = Dfs(s, i, s.Length - 1, dp, wordSet);
                if (bl1 && bl2)
                    return true;
            }
            return false;
        }
        private bool Dfs(string s, int begin, int end, int[,] dp, HashSet<string> wordSet)
        {
            if (IsExist(s, begin, end, dp, wordSet))
                return true;
            for (int i = begin + 1; i <= end; i++)
            {
                bool bl1 = IsExist(s, begin, i - 1, dp, wordSet);
                bool bl2 = IsExist(s, i, s.Length - 1, dp, wordSet);
                if (bl1 && bl2)
                {
                    return true;
                }
                else
                {
                    if (bl1 && bl2 == false)
                    {
                        if (!IsStop(s, i, s.Length - 1, dp, wordSet))
                        {
                            return false;
                        }
                        bool bl = Dfs(s, i, s.Length - 1, dp, wordSet);
                        if (bl)
                        {
                            return true;
                        }
                    }

                }
            }


            return false;
        }
        private bool IsStop(string s, int begin, int end, int[,] dp, HashSet<string> wordSet)
        {
            bool bl1 = false;
            for (int i = 0; i <= end; i++)
            {
                if (IsExist(s, 0, i + 1, dp, wordSet))
                {
                    bl1 = true;
                    break;
                }
            }
            bool bl2 = false;
            for (int i = end; i >= begin; i--)
            {
                if (IsExist(s, i, end, dp, wordSet))
                {
                    bl2 = true;
                    break;
                }
            }
            return bl1 && bl2;
        }

        private bool IsExist(string s, int begin, int end, int[,] dp, HashSet<string> wordSet)
        {
            if (dp[begin, end] == 0)
            {
                string ss = s.Substring(begin, end - begin + 1);
                if (wordSet.Contains(ss))
                {
                    dp[begin, end] = 1;
                    return true;
                }
                else
                {
                    dp[begin, end] = -1;
                    return false;
                }
            }
            else if (dp[begin, end] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool WordBreak(string s, IList<string> wordDict)
        {
            bool[,] dp = new bool[s.Length, s.Length];
            for (int j = 0; j < wordDict.Count; j++)
            {
                string word = wordDict[j];

                int len = s.Length - word.Length;

                int index = s.IndexOf(word);
                if (index < 0)
                    continue;
                for (int i = index; i <= len; i++)
                {
                    int end = i + word.Length - 1;
                    string ss = s.Substring(i, word.Length);
                    if (ss == word)
                    {
                        dp[i, end] = true;

                    }
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (dp[0, i] && dp[i + 1, j])
                    {
                        dp[0, j] = true;
                    }
                }
            }

            return dp[0, s.Length - 1];
        }


    }
}
