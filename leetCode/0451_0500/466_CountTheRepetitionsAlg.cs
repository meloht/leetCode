using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _466_CountTheRepetitionsAlg
    {
        public int GetMaxRepetitions(string s1, int n1, string s2, int n2)
        {
            int ans = 0;
            int len1 = s1.Length;
            int len2 = s2.Length;
            if (len2 * n2 > len1 * n1)
            {
                return ans;
            }
            int idx1 = 0;
            int idx2 = 0;
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
            while (idx1 / len1 < n1)
            {
                if (idx1 % len1 == len1 - 1)
                {
                    int key = idx2 % len2;
                    if (dict.ContainsKey(key))
                    {
                        int[] nums = dict[key];
                        int preIndex1 = nums[0];
                        int preIndex2 = nums[1];

                        int cycleLen = idx1 / len1 - preIndex1 / len1;
                        int cycleNum = (n1 - 1 - idx1 / len1) / cycleLen;
                        int cycle2Num = idx2 / len2 - preIndex2 / len2;

                        idx1 += cycleNum * cycleLen * len1;
                        ans += cycle2Num * cycleNum;
                    }
                    else
                    {

                        dict.Add(key, [idx1, idx2]);
                    }

                }
                if (s1[idx1 % len1] == s2[idx2 % len2])
                {
                    if (idx2 % len2 == len2 - 1)
                    {
                        ans += 1;
                    }
                    idx2++;
                }
                idx1++;
            }


            return ans / n2;
        }

    }
}
