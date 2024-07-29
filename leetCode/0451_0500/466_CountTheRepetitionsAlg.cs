using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _466_CountTheRepetitionsAlg
    {
        public int GetMaxRepetitions(string s1, int n1, string s2, int n2)
        {
            int[] arr1 = GetChar(s1, n1);
            int[] arr2 = GetChar(s2, n2);
            int ans = int.MinValue;
            for (int i = 0; i < 26; i++)
            {
                int cnt2 = arr2[i];
                if (cnt2 == 0)
                {
                    continue;
                }
                int cnt1 = arr1[i];
                int max = cnt1 / cnt2;
                ans = Math.Max(ans, max);
            }
            return ans;
        }
        private int[] GetChar(string s, int n)
        {
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                int idx = s[i] - 'a';
                arr[idx]++;
            }
            for (int i = 0; i < 26; i++)
            {
                arr[i] = arr[i] * n;
            }
            return arr;
        }
    }
}
