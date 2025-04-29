using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _950_RevealCardsInIncreasingOrderAlg
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            int n = deck.Length;
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(i);
            }
            Array.Sort(deck);
            int[] ans = new int[n];
            foreach (var item in deck)
            {
                ans[queue.Dequeue()] = item;
                if (queue.Count > 0)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }
            return ans;
        }
    }
}
