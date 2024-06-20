using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _424_LongestRepeatingCharacterReplacementAlg
    {
        public int CharacterReplacement(string s, int k)
        {
            if (s.Length <= k + 1)
                return s.Length;
            int left = 0;
            int right = 0;
            int maxChar = 0;
            int maxCharIdx = 0;
            int len = 0;

            int[] arr = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                int idx = s[i] - 'A';
                right++;
                len++;

                arr[idx]++;
                if (arr[idx] > maxChar)
                {
                    maxChar = arr[idx];
                    maxCharIdx = idx;
                }

                if (len - maxChar >= k)
                    break;
            }
            int ans = len;
            for (int i = right; i < s.Length; i++)
            {
                int idx = s[i] - 'A';
                arr[idx]++;
                if (arr[idx] > maxChar)
                {
                    maxChar = arr[idx];
                    maxCharIdx = idx;
                }

                len++;
                while (len - maxChar > k)
                {
                    int pre = s[left] - 'A';
                    arr[pre]--;
                    if (pre == maxCharIdx)
                    {
                        var res = GetMax(arr);
                        maxChar = res.max;
                        maxCharIdx = res.idx;
                    }
                    left++;
                    len--;

                }
                ans = Math.Max(ans, len);
            }

            return ans;
        }

        private (int max, int idx) GetMax(int[] arr)
        {
            int ans = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > ans)
                {
                    ans = arr[i];
                    index = i;
                }
            }
            return (ans, index);
        }

        public int CharacterReplacement1(string s, int k)
        {
            int[] arr = new int[26];
            int left = 0;
            int right = 0;
            int n = s.Length;
            int maxChar = 0;

            while (right < n)
            {
                int idx = s[right] - 'A';
                arr[idx]++;
                maxChar = Math.Max(maxChar, arr[idx]);
                if (right - left + 1 - maxChar > k)
                {
                    arr[s[left] - 'A']--;
                    left++;
                }
                right++;

            }
            return right - left;
        }
    }
}
