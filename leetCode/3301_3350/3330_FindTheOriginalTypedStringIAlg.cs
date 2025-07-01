using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3330_FindTheOriginalTypedStringIAlg
    {
        public int PossibleStringCount(string word)
        {
            int n = word.Length, ans = 1;
            for (int i = 1; i < n; ++i)
            {
                if (word[i - 1] == word[i])
                {
                    ++ans;
                }
            }
            return ans;

        }
    }
}
