using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3146_PermutationDifferenceBetweenTwoStringsAlg
    {
        public int FindPermutationDifference(string s, string t)
        {
            int[] dict=new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                int idx = s[i] - 'a';
                dict[idx]= i;
            }
            int ans = 0;
            for (int i = 0; i < t.Length; i++)
            {
                ans += Math.Abs(i - dict[t[i] - 'a']);
            }
            return ans;
        }
    }
}
