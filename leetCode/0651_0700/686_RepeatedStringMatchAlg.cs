using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _686_RepeatedStringMatchAlg
    {
        public int RepeatedStringMatch(string a, string b)
        {
            if (a == b)
                return 1;

            int[] arr1 = new int[26];
           
            foreach (var item in a)
            {
                arr1[item - 'a']++;
            }
            
            foreach (var item in b)
            {
                if (arr1[item - 'a'] == 0)
                    return -1;
            }


            int[] pi = ComputePrefixFunction(b);
            StringBuilder sb = new StringBuilder();

            for (int i = 0;;)
            {
                sb.Append(a);
                i++;
                if (KMPMatcher(sb.ToString(), b, pi))
                {
                    return i;
                }
                if (sb.Length > 2 * b.Length && i > 2)
                {
                    break;
                }

            }
            return -1;
        }

        // 计算模式字符串的前缀函数（失配函数）
        public static int[] ComputePrefixFunction(string pattern)
        {
            int m = pattern.Length;
            int[] pi = new int[m];
            int k = 0;
            for (int i = 1; i < m; i++)
            {
                while (k > 0 && pattern[k] != pattern[i])
                {
                    k = pi[k - 1];
                }
                if (pattern[k] == pattern[i])
                {
                    k++;
                }
                pi[i] = k;
            }
            return pi;
        }

        // KMP字符串匹配主函数，返回模式字符串在主字符串中匹配的位置列表
        public static bool KMPMatcher(string text, string pattern, int[] pi)
        {
            int n = text.Length;
            int m = pattern.Length;

            int q = 0;
            int k = 0;
            while (q < n)
            {
                if (text[q] == pattern[k])
                {
                    q++;
                    k++;
                    if (k == m)
                    {
                        return true;
                    }
                }
                else
                {
                    if (k > 0)
                    {
                        k = pi[k - 1];
                    }
                    else
                    {
                        q++;
                    }
                }
            }
            return false;
        }


        public int RepeatedStringMatch1(string a, string b)
        {
            int an = a.Length, bn = b.Length;
            int index = StrStr(a, b);
            if (index == -1)
            {
                return -1;
            }
            if (an - index >= bn)
            {
                return 1;
            }
            return (bn + index - an - 1) / an + 2;
        }

        public int StrStr(string a, string b)
        {
            int n = a.Length, m = b.Length;
            if (m == 0)
            {
                return 0;
            }
            int[] pi = new int[m];
            for (int i = 1, j = 0; i < m; i++)
            {
                while (j > 0 && b[i] != b[j])
                {
                    j = pi[j - 1];
                }
                if (b[i] == b[j])
                {
                    j++;
                }
                pi[i] = j;
            }
            for (int i = 0, j = 0; i - j < n; i++)
            { // b 开始匹配的位置是否超过第一个叠加的 a
                while (j > 0 && a[i % n] != b[j])
                { // haystack 是循环叠加的字符串，所以取 i % n
                    j = pi[j - 1];
                }
                if (a[i % n] == b[j])
                {
                    j++;
                }
                if (j == m)
                {
                    return i - m + 1;
                }
            }
            return -1;
        }


    }
}
