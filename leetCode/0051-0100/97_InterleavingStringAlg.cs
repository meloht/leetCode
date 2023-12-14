using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _97_InterleavingStringAlg
    {
        public bool IsInterleave1(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }
            if (s1.Length == 0 && s2.Length == 0 && s3.Length == 0)
                return true;

            bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
            dp[0, 0] = true;

            for (int i = 0; i < s1.Length; i++)
            {
                dp[i + 1, 0] = s1.Substring(0, i + 1) == s3.Substring(0, i + 1);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                dp[0, i + 1] = s2.Substring(0, i + 1) == s3.Substring(0, i + 1);
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (dp[i - 1, j])
                    {
                        dp[i, j] = s1[i - 1] == s3[i + j - 1];
                    }
                    else if (dp[i, j - 1])
                    {
                        dp[i, j] = s2[j - 1] == s3[i + j - 1];
                    }
                }
            }

            return dp[s1.Length, s2.Length];
        }
        /// <summary>
        /// 滚动数组
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }
            if (s1.Length == 0 && s2.Length == 0 && s3.Length == 0)
                return true;

            bool[] dp = new bool[s2.Length + 1];
            dp[0] = true;

            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {
                    if (i > 0)
                    {
                        dp[j] = dp[j] && s1[i - 1] == s3[i + j - 1];
                    }
                    if (j > 0)
                    {
                        dp[j] = dp[j] || (dp[j - 1] && s2[j - 1] == s3[i + j - 1]);
                    }

                }
            }

            return dp[s2.Length];
        }
    }
}
