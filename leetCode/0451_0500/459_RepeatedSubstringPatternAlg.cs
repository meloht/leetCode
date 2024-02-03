using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0451_0500
{
    public class _459_RepeatedSubstringPatternAlg
    {
        public bool RepeatedSubstringPattern1(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);
                int step = sb.Length;
                string ss = sb.ToString();
                if (s.Length % ss.Length == 0 && ss.Length < s.Length)
                {
                    bool bl = true;
                    for (int j = i + 1; j < s.Length; j += step)
                    {
                        if (bl == false)
                            break;
                        int end = j + step;

                        for (int k = j; k < end; k++)
                        {
                            if (ss[k - j] != s[k])
                            {
                                bl = false;
                                break;
                            }
                        }
                    }
                    if (bl)
                        return true;
                }

            }
            return false;
        }

        public bool RepeatedSubstringPattern2(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                int step = i + 1;
                string ss = s.Substring(0, step);
                if (s.Length % ss.Length == 0 && ss.Length < s.Length)
                {
                    bool bl = true;
                    for (int j = i + 1; j < s.Length; j += step)
                    {
                        if (s.Substring(j, step) != ss)
                        {
                            bl = false;
                            break;
                        }

                    }
                    if (bl)
                        return true;
                }

            }
            return false;
        }

        public bool RepeatedSubstringPattern3(string s)
        {
            return (s + s).IndexOf(s, 1) != s.Length;
        }

        public bool RepeatedSubstringPattern4(string s)
        {
            var span = s.AsSpan();

            for (int i = 0; (i + 1) * 2 <= s.Length; i++)
            {
                int step = i + 1;
                var ss = span.Slice(0, step);
                if (s.Length % ss.Length == 0 && ss.Length < s.Length)
                {
                    bool bl = true;
                    for (int j = i + 1; j < s.Length; j += step)
                    {
                        if (!span.Slice(j, step).SequenceEqual(ss))
                        {
                            bl = false;
                            break;
                        }

                    }
                    if (bl)
                        return true;
                }

            }
            return false;
        }

        public bool RepeatedSubstringPattern5(string s)
        {
            int n = s.Length;
            for (int i = 1; i * 2 <= n; ++i)
            {
                if (n % i == 0)
                {
                    bool match = true;
                    for (int j = i; j < n; ++j)
                    {
                        if (s[j] != s[j - i])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// kmp
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool RepeatedSubstringPattern6(string s)
        {
            string ss = s + s;

            return KMPSearch(ss,s);
        }
        private bool KMPSearch(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;

            int[] next = ComputeNext(pattern);

            int i = 1; // index for text
            int j = 0; // index for pattern

            while (i < n)
            {
                if (pattern[j] == text[i])
                {
                    j++;
                    i++;
                }

                if (j == m)
                {
                    if (i - j != m)
                        return true;
                    j = next[j - 1];
                }
                else if (i < n && pattern[j] != text[i])
                {
                    if (j != 0)
                    {
                        j = next[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return false;
        }
        private int[] ComputeNext(string pattern)
        {
            int m = pattern.Length;
            int[] next = new int[m];
            int len = 0;
            int i = 1;

            while (i < m)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    next[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = next[len - 1];
                    }
                    else
                    {
                        next[i] = 0;
                        i++;
                    }
                }
            }

            return next;
        }

        public bool RepeatedSubstringPattern(string s)
        {
            return Kmp(s);
        }
        public bool Kmp(string pattern)
        {
            int n = pattern.Length;
            int[] fail = new int[n];
            Array.Fill(fail, -1);
            for (int i = 1; i < n; ++i)
            {
                int j = fail[i - 1];
                while (j != -1 && pattern[j + 1] != pattern[i])
                {
                    j = fail[j];
                }
                if (pattern[j + 1] == pattern[i])
                {
                    fail[i] = j + 1;
                }
            }
            return fail[n - 1] != -1 && n % (n - fail[n - 1] - 1) == 0;
        }



    }
}
