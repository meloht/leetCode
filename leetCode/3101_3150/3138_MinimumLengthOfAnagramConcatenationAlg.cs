using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3138_MinimumLengthOfAnagramConcatenationAlg
    {
        public int MinAnagramLength(string s)
        {
            int[] map = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                int idx = s[i] - 'a';

                map[idx]++;
            }
            int[] nums = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                int idx = s[i] - 'a';
                nums[idx]++;

                if (s.Length % (i + 1) == 0)
                {
                    int j = i + 1;
                    int end = j + i + 1;
                    bool bl = true;
                    while (j < end && end <= s.Length)
                    {
                        int[] nums2 = new int[26];
                        for (; j < end; j++)
                        {
                            int idxx = s[j] - 'a';
                            nums2[idxx]++;
                        }
                        if (nums.SequenceEqual(nums2))
                        {
                            end += (i + 1);
                        }
                        else
                        {
                            bl = false;
                            break;
                        }
                    }
                    if (bl)
                    {
                        return i + 1;
                    }
                }
            }

            return s.Length;
        }
    }
}
