using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3258_CountSubstringsThatSatisfyKConstraintIAlg
    {
        public int CountKConstraintSubstrings(string s, int k)
        {
            int ans = 0;
            int left = 0;
            int[] cnt = new int[2];
            for (int i = 0; i < s.Length; i++)
            {
                cnt[s[i] & 1]++;
                while (cnt[0] > k && cnt[1] > k)
                {
                    cnt[s[left] & 1]--;
                    left++;
                }
                ans += i - left + 1;
            }
            return ans;

        }
    }
}
