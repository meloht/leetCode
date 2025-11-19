using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1151_1200
{
    public class _1170_CompareStringsByFrequencyOfTheSmallestCharacterAlg
    {
        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            int[] ws = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                ws[i] = GetCount(words[i]);
            }
            Array.Sort(ws);
            int[] ans = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int count = GetCount(queries[i]);
                int idx = LeftBinarySearch(ws, count);
                ans[i] = ws.Length - idx;
            }


            return ans;
        }

        private int GetCount(string s)
        {
            int[] arr = new int[26];
            foreach (var item in s)
            {
                arr[item - 'a']++;
            }
            foreach (var item in arr)
            {
                if (item > 0)
                    return item;
            }
            return 0;
        }
        private int LeftBinarySearch(int[] list, int target)
        {
            int left = 0;
            int right = list.Length - 1;
            int ans = list.Length;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    ans = mid;
                    right = mid - 1;
                }
            }
            return ans;
        }

        public int[] NumSmallerByFrequency1(string[] queries, string[] words)
        {
            int[] count = new int[12];
            foreach (string s in words)
            {
                count[F(s)]++;
            }
            for (int i = 9; i >= 1; i--)
            {
                count[i] += count[i + 1];
            }
            int[] res = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                string s = queries[i];
                res[i] = count[F(s) + 1];
            }
            return res;
        }

        public int F(string s)
        {
            int cnt = 0;
            char ch = 'z';
            foreach (char c in s)
            {
                if (c < ch)
                {
                    ch = c;
                    cnt = 1;
                }
                else if (c == ch)
                {
                    cnt++;
                }
            }
            return cnt;
        }


    }
}
