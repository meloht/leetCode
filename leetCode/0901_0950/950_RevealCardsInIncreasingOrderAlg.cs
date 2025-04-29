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
            int[] arr = new int[deck.Length];
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < deck.Length; i++)
            {
                arr[i] = i;
                queue.Enqueue(i);
            }

            Array.Sort(arr, (x, y) => deck[x] - deck[y]);

            int[][] order = new int[deck.Length][];
            int idx = 0;
            while (queue.Count > 0)
            {
                int index = queue.Dequeue();
                order[idx] = [index, idx];
                idx++;
                if (queue.Count > 0)
                {
                    var item = queue.Dequeue();
                    queue.Enqueue(item);
                }
            }
            Array.Sort(order, (x, y) => arr[x[1]] - arr[y[1]]);
            int[] ans = new int[deck.Length];
            for (int i = 0; i < deck.Length; i++)
            {
                ans[i] = deck[order[i][0]];
            }

            return ans;
        }
    }
}
