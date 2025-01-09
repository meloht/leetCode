using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3297_CountSubstringsThatCanBeRearrangedToContainAStringIAlg
    {
        public long ValidSubstringCount1(string word1, string word2)
        {
            if (word1.Length < word2.Length)
                return 0;

            int[] arr = new int[26];
            foreach (var item in word2)
            {
                arr[item - 'a']++;
            }
            int n = word1.Length;
            long ans = 0;
            int[] map = new int[26];
            for (int i = 0, j = 0; i < n; i++)
            {
                map[word1[i] - 'a']++;
                while (IsContainPrefix(arr, map))
                {
                    ans += n - i;
                    map[word1[j] - 'a']--;
                    j++;
                }
            }
            return ans;
        }

        public bool IsContainPrefix(int[] arr, int[] map)
        {
            for (int j = 0; j < 26; j++)
            {
                if (arr[j] > map[j])
                {
                    return false;
                }
            }
            return true;
        }


        public long ValidSubstringCount(string word1, string word2)
        {
            if (word1.Length < word2.Length)
                return 0;

            int[] arr = new int[26];
            foreach (var item in word2)
            {
                arr[item - 'a']++;
            }
            int less = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    less++;
                }
            }

            int n = word1.Length;
            long ans = 0;

            for (int i = 0, j = 0; i < n; i++)
            {
                arr[word1[i] - 'a']--;
                if (arr[word1[i] - 'a'] == 0)
                {
                    less--;
                }
                while (less == 0)
                {
                    ans += n - i;
                    int cnt = arr[word1[j] - 'a'];
                    arr[word1[j] - 'a']++;
                    if (cnt == 0 && arr[word1[j] - 'a'] > 0)
                    {
                        less++;
                    }
                    if (cnt > 0 && arr[word1[j] - 'a'] == 0)
                    {
                        less--;
                    }
                    j++;
                }
            }
            return ans;
        }


    }
}
