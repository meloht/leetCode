using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2601_2650
{
    public class _2612_MinimumReverseOperationsAlg
    {
        public int[] MinReverseOperations(int n, int p, int[] banned, int k)
        {
            HashSet<int> ban = new HashSet<int>(banned);
            SortedSet<int>[] sets = new SortedSet<int>[2];
            sets[0] = new SortedSet<int>();
            sets[1] = new SortedSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (i != p && !ban.Contains(i))
                {
                    sets[i % 2].Add(i);
                }
            }
            int[] ans = new int[n];
            Array.Fill(ans, -1);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(p);
            ans[p] = 0;
            while (queue.Count > 0)
            {
                int i = queue.Dequeue();
                int mn = Math.Max(i - k + 1, k - i - 1);
                int mx = Math.Min(i + k - 1, n * 2 - k - i - 1);
                SortedSet<int> set = sets[mx % 2];

                var toRemove=new List<int>();
                var it = set.GetViewBetween(mn, mx).GetEnumerator();
                while (it.MoveNext())
                {
                    int current = it.Current;
                    ans[current] = ans[i] + 1;
                    queue.Enqueue(current);
                    toRemove.Add(current);
                }
                foreach (var item in toRemove)
                {
                    set.Remove(item);
                }
            }
            return ans;
        }
    }
}
