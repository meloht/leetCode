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
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var wordDictSet = new HashSet<string>(wordDict);

            var dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 1; i <= s.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (dp[j] && wordDictSet.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];

        }



        public bool WordBreak1(string s, IList<string> wordDict)
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
