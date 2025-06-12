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
            int inf = int.MaxValue / 2;

            int ans = -inf;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        continue;

                    }

                    int[] curr = new int[5];
                    int[] pre = new int[5];
                    int[][] mins = [[inf, inf], [inf, inf]];
                    int left = 0;
                    for (int m = 0; m < s.Length; m++)
                    {
                        curr[s[m] - '0']++;
                        int r = m + 1;

                        while (r - left >= k && curr[i] > pre[i] && curr[j] > pre[j])
                        {
                            int p = pre[i] & 1;
                            int q = pre[j] & 1;
                            mins[p][q] = Math.Min(mins[p][q], pre[i] - pre[j]);
                            pre[s[left] - '0']++;
                            left++;
                        }
                        ans = Math.Max(ans, curr[i] - curr[j] - mins[curr[i] & 1 ^ 1][curr[j] & 1]);
                    }
                }
            }

            return ans;
        }
    }
}
