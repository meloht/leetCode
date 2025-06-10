using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3442_MaximumDifferenceBetweenEvenAndOddFrequencyIAlg
    {
        public int MaxDifference(string s)
        {
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
            }
            int a1 = 0;
            int a2 = s.Length;
            for (int i = 0; i < 26; i++)
            {
                if (arr[i] > 0)
                {
                    if (arr[i] % 2 == 0)
                    {
                        a2 = Math.Min(arr[i], a2);
                    }
                    else
                    {
                        a1 = Math.Max(arr[i], a1);
                    }
                }
            }
            return a1 - a2;
        }
    }
}
