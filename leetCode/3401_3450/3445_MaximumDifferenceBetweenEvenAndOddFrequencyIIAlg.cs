using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3445_MaximumDifferenceBetweenEvenAndOddFrequencyIIAlg
    {
        public int MaxDifference(string s, int k)
        {
            int[] arr = new int[5];
            int ans = int.MinValue;
            for (int i = 0, j = 0; i < s.Length; i++)
            {
                arr[s[i] - '0']++;
                if (i - j + 1> k)
                {
                    arr[s[j] - '0']--;
                }
                int n1 = 0;
                int n2 = int.MaxValue;
                foreach (var item in arr)
                {
                    if (item > 0)
                    {
                        if (item % 2 == 0)
                        {
                            n2 = Math.Min(item, n2);
                        }
                        else
                        {
                            n1 = Math.Max(item, n1);
                        }

                    }
                }
                n2 = n2 == int.MaxValue ? 0 : n2;
                ans = Math.Max(ans, n1 - n2);
            }
            return ans;
        }
    }
}
