using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2401_2450
{
    public class _2414_LengthOfTheLongestAlphabeticalContinuousSubstringAlg
    {
      
        public int LongestContinuousSubstring(string s)
        {
            int ans = 1;
            int count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] + 1 == s[i])
                {
                    count++;
                    ans = Math.Max(ans, count);
                }
                else
                {
                    count = 1;
                }
            }
            return ans;
        }
       

    }
}
