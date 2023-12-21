using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _131_PalindromePartitioningAlg
    {

        public IList<IList<string>> Partition1(string s)
        {
            HashSet<string> set = new HashSet<string>();
            List<IList<string>> res = new List<IList<string>>();

            List<string> ls = new List<string>();
            for (int j = 0; j < s.Length; j++)
            {
                ls.Add(s[j].ToString());
            }
            res.Add(ls);
            Queue<List<string>> queue = new Queue<List<string>>();
            queue.Enqueue(ls);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int ii = 0; ii < count; ii++)
                {
                    var list = queue.Dequeue();

                    for (int j = 1; j < list.Count; j++)
                    {
                        string pre = list[j - 1];
                        string curr = list[j];
                        if (curr == pre)
                        {
                            string word = $"{pre}{curr}";
                            AddAns(queue, list, word, j - 1, j, res, set);
                        }
                        if (j + 1 < list.Count)
                        {
                            string next = list[j + 1];
                            if (next == pre)
                            {
                                string word = $"{pre}{curr}{next}";
                                AddAns(queue, list, word, j - 1, j + 1, res, set);
                            }
                        }
                    }
                }
            }


            return res;
        }

        private void AddAns(Queue<List<string>> queue, List<string> list, string word, int begin, int end, List<IList<string>> res, HashSet<string> set)
        {
            List<string> ans = new List<string>();
            for (int i = 0; i < begin; i++)
            {
                ans.Add(list[i]);
            }
            ans.Add(word);
            for (int i = end + 1; i < list.Count; i++)
            {
                ans.Add(list[i]);
            }
            string ress = string.Join(",", ans);
            if (!set.Contains(ress))
            {
                queue.Enqueue(ans);
                set.Add(ress);
                res.Add(ans);
            }

        }

        List<IList<string>> result=new List<IList<string>>();
        List<string> list = new List<string>();
        public IList<IList<string>> Partition(string s)
        {
            bool[][] dp = new bool[s.Length][];
            for (int i = 0; i < s.Length; i++)
            {
                dp[i] = new bool[s.Length];
                Array.Fill(dp[i], true);

            }


            for (int i = s.Length - 1; i >= 0; --i)
            {
                for (int j = i + 1; j < s.Length; ++j)
                {
                    dp[i][j] = (s[i] == s[j]) && dp[i + 1][j - 1];
                   
                }
            }
            Dfs(s, 0, dp);


            return result;
        }
        private void Dfs(string s,int i, bool[][] dp)
        {
            if (i == s.Length)
            {
                result.Add(new List<string>(list));
                return;
            }
            for (int j = i; j < s.Length; j++)
            {
                if (dp[i][j])
                {
                    list.Add(s.Substring(i, j + 1 - i));
                    Dfs(s, j + 1, dp);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }

    }
}
