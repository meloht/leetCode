using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3110_ScoreOfAStringAlg
    {
        public int ScoreOfString(string s)
        {
            int ans = 0;
            for (int i = 1; i < s.Length; i++)
            {
                ans += Math.Abs(s[i - 1] - s[i]);
            }
            return ans;
        }
    }
}
