using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1048_LongestStringChainAlg
    {
        private Dictionary<string, int> dict = new Dictionary<string, int>();
        public int LongestStrChain(string[] words)
        {
            foreach (string word in words)
            {
               
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 0);
                }
            }

            int ans = 0;
            foreach (var item in dict.Keys)
            {
                ans = Math.Max(ans, Dfs(item));
            }

            return ans;
        }
        private int Dfs(string s)
        {
            int res = dict[s];
            if (res > 0)
            {
                return res;
            }
            if (s.Length == 1)
            {
                dict[s] = res + 1;
                return res + 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                string t = s.Substring(0, i) + s.Substring(i + 1);

                if (dict.ContainsKey(t))
                {
                    res = Math.Max(res, Dfs(t));
                }
            }
            dict[s] = res + 1;
            return res + 1;
        }
    }
}
