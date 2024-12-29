using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1366_RankTeamsByVotesAlg
    {
        public string RankTeams(string[] votes)
        {
            int n = votes[0].Length;
            Node[] arr = new Node[26];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Node('0', n);
            }

            foreach (var vote in votes)
            {
                for (int i = 0; i < vote.Length; i++)
                {
                    var idx = vote[i]-'A';
                    if (arr[idx].Item == '0')
                    {
                        arr[idx].Item = vote[i];
                    }

                    arr[idx].Cnt[i]++;

                }

            }
            Array.Sort(arr, (x, y) =>
            {
                for (int i = 0; i < n; i++)
                {
                    if (y.Cnt[i] != x.Cnt[i])
                    {
                        return y.Cnt[i] - x.Cnt[i];
                    }
                }
                return x.Item.CompareTo(y.Item);
            });
            StringBuilder ans = new StringBuilder();
            foreach (var item in arr)
            {
                if (item.Item != '0')
                {
                    ans.Append(item.Item);
                }
              
            }
            return ans.ToString();
        }


        class Node
        {
            public char Item;
            public int[] Cnt;

            public Node(char item, int n)
            {
                Item = item;
                Cnt = new int[n];
            }

        }
    }
}
