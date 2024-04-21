using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _953_VerifyingAnAlienDictionaryAlg
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < order.Length; i++)
            {
                dict.Add(order[i], i);
            }

            for (int i = 1; i < words.Length; i++)
            {
                int len = Math.Min(words[i - 1].Length, words[i].Length);
                bool bl = false;
                for (int j = 0; j < len; j++)
                {
                    int prev = dict[words[i - 1][j]];
                    int curr = dict[words[i][j]];
                    if (prev > curr)
                    {
                        return false;

                    }
                    else if (curr > prev)
                    {
                        bl = true;
                        break;
                    }


                }
                if (bl == false && words[i - 1].Length > words[i].Length)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
