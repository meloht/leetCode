using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _140_WordBreakIIAlg
    {
        List<string> res = new List<string>();
       
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var wordDictSet = new HashSet<string>(wordDict);
            List<string> list = new List<string>();

            Dfs(s, wordDictSet, list);
            return res;
        }

        private void Dfs(string s, HashSet<string> wordDictSet, List<string> list)
        {
            if (string.IsNullOrEmpty(s))
            {
                return;
            }

            for (int i = 1; i <= s.Length; i++)
            {
                string ss = s.Substring(0, i);
                bool blleft = wordDictSet.Contains(ss);
              
                if (blleft)
                {
                    list.Add(ss);
                    if (i < s.Length)
                    {
                        string ss2 = s.Substring(i);
                        Dfs(ss2, wordDictSet, list);
                        list.RemoveAt(list.Count - 1);
                    }
                    else
                    {
                        res.Add(string.Join(" ", list));
                        list.RemoveAt(list.Count - 1);
                    }
                }
            }

        }
    }
}
