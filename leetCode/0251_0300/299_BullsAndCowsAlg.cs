using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _299_BullsAndCowsAlg
    {
        public string GetHint(string secret, string guess)
        {
            int a = 0;
            int b = 0;
            int[] dict = new int[10];

            foreach (var item in secret)
            {
                dict[item - '0']++;
            }
            for (int i = 0; i < guess.Length; i++)
            {
                int index = guess[i] - '0';
                if (dict[index] > 0)
                {
                    if (guess[i] == secret[i])
                    {
                        a++;
                        dict[index]--;
                    }
                }

            }
            for (int i = 0; i < guess.Length; i++)
            {
                int index = guess[i] - '0';
                if (dict[index] > 0)
                {
                    if (guess[i] != secret[i])
                    {
                        b++;
                        dict[index]--;
                    }
                }
            }

            return $"{a}A{b}B";
        }
    }
}
