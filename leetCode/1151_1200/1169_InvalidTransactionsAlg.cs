using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1151_1200
{
    public class _1169_InvalidTransactionsAlg
    {
        public IList<string> InvalidTransactions(string[] transactions)
        {
            string[][] trans = new string[transactions.Length][];
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            HashSet<int> list = new HashSet<int>();
            for (int i = 0; i < transactions.Length; i++)
            {
                string[] items = transactions[i].Split(',');

                trans[i] = items;


                if (int.Parse(items[2]) > 1000)
                {
                    list.Add(i);

                }
                if (dict.ContainsKey(items[0]))
                {
                    var ls = dict[items[0]];
                    bool bl = false;
                    foreach (var idx in ls)
                    {
                        string[] arr = trans[idx];
                        if (Math.Abs(int.Parse(arr[1]) - int.Parse(items[1])) <= 60 && arr[3] != items[3])
                        {
                            list.Add(idx);
                            bl = true;
                        }
                    }
                    if (bl)
                    {
                        list.Add(i);
                    }
                }

                if (dict.ContainsKey(items[0]))
                {
                    dict[items[0]].Add(i);
                }
                else
                {
                    dict.Add(items[0], [i]);
                }
            }

            List<string> ans=new List<string>();
            foreach (var item in list)
            {
                ans.Add(transactions[item]);
            }


            return ans;
        }
    }
}
