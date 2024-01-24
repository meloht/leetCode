using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _438_FindAllAnagramsInAStringAlg
    {
        public IList<int> FindAnagrams1(string s, string p)
        {
            List<int> list = new List<int>();
            int n = s.Length;
            int m = p.Length;
            if (n < m)
                return list;
            int[] arr = new int[26];
            int[] arr2 = new int[26];
            for (int i = 0; i < m && i < n; i++)
            {
                int ch = p[i] - 'a';
                int ch2 = s[i] - 'a';
                arr[ch]++;
                arr2[ch2]++;
            }
            if (arr.SequenceEqual(arr2))
            {
                list.Add(0);
            }
            for (int i = m, j = 0; i < n; i++, j++)
            {
                int ch2 = s[i] - 'a';
                int prev = s[j] - 'a';
                arr2[prev]--;
                arr2[ch2]++;
                if (arr.SequenceEqual(arr2))
                {
                    list.Add(j + 1);
                }
            }

            return list;
        }

        public IList<int> FindAnagrams(string s, string p)
        {
            int sLen = s.Length, pLen = p.Length;

            if (sLen < pLen)
            {
                return new List<int>();
            }

            IList<int> ans = new List<int>();
            int[] count = new int[26];
            for (int i = 0; i < pLen; ++i)
            {
                ++count[s[i] - 'a'];
                --count[p[i] - 'a'];
            }

            int differ = 0;
            for (int j = 0; j < 26; ++j)
            {
                if (count[j] != 0)
                {
                    ++differ;
                }
            }

            if (differ == 0)
            {
                ans.Add(0);
            }

            for (int i = 0; i < sLen - pLen; ++i)
            {
                if (count[s[i] - 'a'] == 1)
                {  // 窗口中字母 s[i] 的数量与字符串 p 中的数量从不同变得相同
                    --differ;
                }
                else if (count[s[i] - 'a'] == 0)
                {  // 窗口中字母 s[i] 的数量与字符串 p 中的数量从相同变得不同
                    ++differ;
                }
                --count[s[i] - 'a'];

                if (count[s[i + pLen] - 'a'] == -1)
                {  // 窗口中字母 s[i+pLen] 的数量与字符串 p 中的数量从不同变得相同
                    --differ;
                }
                else if (count[s[i + pLen] - 'a'] == 0)
                {  // 窗口中字母 s[i+pLen] 的数量与字符串 p 中的数量从相同变得不同
                    ++differ;
                }
                ++count[s[i + pLen] - 'a'];

                if (differ == 0)
                {
                    ans.Add(i + 1);
                }
            }

            return ans;
        }


    }
}
