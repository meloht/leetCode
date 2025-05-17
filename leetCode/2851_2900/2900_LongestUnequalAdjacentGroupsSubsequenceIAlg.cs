using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2851_2900
{
    public class _2900_LongestUnequalAdjacentGroupsSubsequenceIAlg
    {

        public IList<string> GetLongestSubsequence(string[] words, int[] groups)
        {
            List<string> ans = new List<string>();
            int n = groups.Length;
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1 || groups[i] != groups[i + 1])
                { // i 是连续相同段的末尾
                    ans.Add(words[i]);
                }
            }
            return ans;

        }
       
    }
}
