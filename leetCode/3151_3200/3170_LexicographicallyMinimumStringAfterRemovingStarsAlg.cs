using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3170_LexicographicallyMinimumStringAfterRemovingStarsAlg
    {
        public string ClearStars1(string s)
        {
            PriorityQueue<int,int> queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => 
            {
                if (s[x] == s[y])
                {
                    return y - x;
                }
                return s[x].CompareTo(s[y]);
            }));

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    if (queue.Count > 0)
                    {
                        queue.Dequeue();
                    }
                }
                else
                {
                    queue.Enqueue(i, i);
                }
            }
            HashSet<int> set = [];
            while (queue.Count > 0) 
            {
                set.Add(queue.Dequeue());
            }
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*'||!set.Contains(i)) 
                {
                    continue;
                }
                stringBuilder.Append(s[i]);
            }

            return stringBuilder.ToString();

        }

        public string ClearStars(string s)
        {
            Stack<int>[] cnt = new Stack<int>[26];
            for (int i = 0; i < 26; i++)
            {
                cnt[i] = new Stack<int>();
            }
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != '*')
                {
                    cnt[arr[i] - 'a'].Push(i);
                }
                else
                {
                    for (int j = 0; j < 26; j++)
                    {
                        if (cnt[j].Count > 0)
                        {
                            arr[cnt[j].Pop()] = '*';
                            break;
                        }
                    }
                }
            }
            return new string(Array.FindAll(arr, c => c != '*'));
        }

    }
}
