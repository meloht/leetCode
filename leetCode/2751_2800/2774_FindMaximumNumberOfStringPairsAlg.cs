using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2774_FindMaximumNumberOfStringPairsAlg
    {
        public int MaximumNumberOfStringPairs1(string[] words)
        {
            int ans = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var aa = words[i].ToArray();
                Array.Reverse(aa);
                for (int j = i + 1; j < words.Length; j++)
                {
                    var ss = words[j].ToArray();
                  
                    if (ss.SequenceEqual(aa))
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
        public int MaximumNumberOfStringPairs(string[] words)
        {
            int n = words.Length;
            int ans = 0;
            ISet<int> seen = new HashSet<int>();
            for (int i = 0; i < n; ++i)
            {
                if (seen.Contains(words[i][1] * 100 + words[i][0]))
                {
                    ++ans;
                }
                seen.Add(words[i][0] * 100 + words[i][1]);
            }
            return ans;
        }


    }
}
