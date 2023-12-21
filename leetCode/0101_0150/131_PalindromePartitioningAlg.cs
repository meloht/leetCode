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
        HashSet<string> set = new HashSet<string>();
        public IList<IList<string>> Partition(string s)
        {
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
                            AddAns(queue, res, list, word, j - 1, j);
                        }
                        if (j + 1 < list.Count)
                        {
                            string next = list[j + 1];
                            if (next == pre)
                            {
                                string word = $"{pre}{curr}{next}";
                                AddAns(queue, res, list, word, j - 1, j + 1);
                            }
                        }
                    }
                }
            }

            return res;
        }

        private void AddAns(Queue<List<string>> queue, List<IList<string>> res, List<string> list, string word, int begin, int end)
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
                res.Add(ans);
                set.Add(ress);
            }
           
        }
    
    }
}
