using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _438_FindAllAnagramsInAStringAlg
    {
        public IList<int> FindAnagrams(string s, string p)
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
    }
}
