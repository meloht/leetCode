using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1051_1100
{
    public class _1096_BraceExpansionIIAlg
    {
        private int i = 0;
        public IList<string> BraceExpansionII(string expression)
        {
            char[] s = expression.ToCharArray();
            List<string> ans = new List<string>(Dfs(s));
            ans.Sort();
            return ans;
        }

        private HashSet<string> Dfs(char[] exp)
        {
            HashSet<string> res = new HashSet<string>();
            HashSet<string> cur = new HashSet<string>();
            cur.Add("");
            while (i < exp.Length)
            {
                char ch = exp[i];
                i++;
                if (ch == '}')
                {
                    break;
                }
                if (ch == ',')
                {
                    foreach (var item in cur)
                    {
                        res.Add(item);
                    }
                    cur.Clear();
                    cur.Add("");
                }
                else if (ch == '{')
                {
                    HashSet<string> subRes = Dfs(exp);
                    HashSet<string> newSet = new HashSet<string>();
                    foreach (string s in cur)
                    {
                        foreach (string t in subRes)
                        {
                            newSet.Add(s + t);
                        }
                    }
                    cur = newSet;
                }
                else
                {
                    HashSet<string> newSet = [];
                    foreach (var item in cur)
                    {
                        newSet.Add(item + ch);
                    }
                    cur = newSet;
                }
            }

            foreach (var item in cur)
            {
                res.Add(item);
            }
            return res;
        }
    }
}
