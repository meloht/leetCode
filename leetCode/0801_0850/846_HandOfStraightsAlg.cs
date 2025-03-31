using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _846_HandOfStraightsAlg
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < hand.Length; i++)
            {
                if (dict.ContainsKey(hand[i]))
                {
                    dict[hand[i]]++;
                }
                else
                {
                    dict.Add(hand[i], 1);
                }

            }

            Array.Sort(hand);

            for (int i = 0; i < hand.Length; i++)
            {
                if (dict.ContainsKey(hand[i]) && dict[hand[i]] > 0)
                {
                    int end = hand[i] + groupSize;
                    for (int j = hand[i]; j < end; j++)
                    {
                        if (!dict.ContainsKey(j))
                            return false;

                        dict[j]--;
                        if (dict[j] == 0)
                        {
                            dict.Remove(j);
                        }
                    }
                }
            }

            if (dict.Count > 0)
                return false;


            return true;
        }
    }
}
