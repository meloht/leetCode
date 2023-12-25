using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _139_WordBreakAlg
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> wordSet = new HashSet<string>(wordDict);
            int[,] dp = new int[s.Length, s.Length];
         
            if (wordSet.Contains(s))
                return true;
            bool bl = Dfs(s, 0, dp, wordSet);
            return bl;
        }
        private bool Dfs(string s, int index, int[,] dp, HashSet<string> wordSet)
        {
            for (int i = index + 1; i < s.Length; i++)
            {
                bool bl1 = IsExist(s, index, i - 1, dp, wordSet);
                bool bl2 = IsExist(s, i, s.Length - 1, dp, wordSet);
                if (bl1 && bl2)
                {
                    return true;
                }
                else
                {
                    if (bl1 && bl2 == false)
                    {
                        bool bl = Dfs(s, i, dp, wordSet);
                        if (bl)
                        {
                            return true;
                        }
                    }

                }
            }

            return false;
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

    }
}
