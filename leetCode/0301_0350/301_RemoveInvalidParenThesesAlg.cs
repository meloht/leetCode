using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _301_RemoveInvalidParenThesesAlg
    {
        int max = 0;
        public IList<string> RemoveInvalidParentheses(string s)
        {
            HashSet<string> res = new HashSet<string>();

            int left = 0;
            int right = 0;
            foreach (char c in s)
            {
                if (c == '(')
                {
                    left++;
                }
                else if (c == ')')
                {
                    if (left == 0)
                    {
                        right++;
                    }
                    else
                    {
                        left--;
                    }
                }
            }
            max = s.Length - left - right;
            Dfs(s, 0, 0, new List<char>(), res);
            return res.ToList();
        }

        private void Dfs(string s, int i, int n, List<char> ls, HashSet<string> res)
        {
            if (n < 0)
                return;
            if (n > 0 && (s.Length - i) < n)
                return;
            if (i >= s.Length)
            {
                if (n == 0 && ls.Count == max)
                {
                    res.Add(new string(ls.ToArray()));
                }
                return;
            }

            if (s[i] == ')')
            {
                if (n > 0)
                {
                    ls.Add(s[i]);
                    Dfs(s, i + 1, n - 1, ls, res);
                    ls.RemoveAt(ls.Count - 1);
                }

                Dfs(s, i + 1, n, ls, res);
            }
            else if (s[i] == '(')
            {
                ls.Add(s[i]);
                Dfs(s, i + 1, n + 1, ls, res);
                ls.RemoveAt(ls.Count - 1);

                Dfs(s, i + 1, n, ls, res);
            }
            else
            {
                ls.Add(s[i]);
                Dfs(s, i + 1, n, ls, res);
                ls.RemoveAt(ls.Count - 1);
            }
        }
    }
}
