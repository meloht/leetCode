using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _942_DiStringMatchAlg
    {
        public int[] DiStringMatch(string s)
        {
            int[] ans = new int[s.Length + 1];
            int left = 0;
            int right = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    ans[i] = left;
                    left++;
                    if (i == s.Length - 1)
                    {
                        ans[i+1] = left;
                    }
                }
                else
                {
                    ans[i] = right;
                    right--;
                    if (i == s.Length - 1)
                    {
                        ans[i + 1] = right;
                    }
                }
            }

            return ans;
        }
    }
}
