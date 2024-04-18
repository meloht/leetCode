using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _821_ShortestDistanceToACharacterAlg
    {
        public int[] ShortestToChar1(string s, char c)
        {
            int[] result = new int[s.Length];
            int prev = -1;
            int curr = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (curr < i && curr > -1)
                {
                    prev = curr;
                    curr = -1;
                }
                if (curr == -1)
                {
                    curr = GetNext(s, c, i);
                }
                bool bl = false;
                if (curr != -1 && i <= curr)
                {
                    result[i] = curr - i;
                    bl = true;
                }

                if (prev != -1 && i >= prev)
                {
                    if (bl)
                    {
                        result[i] = Math.Min(i - prev, result[i]);
                    }
                    else
                    {
                        result[i] = i - prev;
                    }
                   
                }

            }
            return result;
        }
        private int GetNext(string s, char c, int index)
        {
            for (int j = index; j < s.Length; j++)
            {
                if (s[j] == c)
                {
                    return j;

                }
            }
            return -1;
        }

        public int[] ShortestToChar(string s, char c)
        {
            int n = s.Length;
            int[] ans = new int[n];

            for (int i = 0, idx = -n; i < n; ++i)
            {
                if (s[i] == c)
                {
                    idx = i;
                }
                ans[i] = i - idx;
            }

            for (int i = n - 1, idx = 2 * n; i >= 0; --i)
            {
                if (s[i] == c)
                {
                    idx = i;
                }
                ans[i] = Math.Min(ans[i], idx - i);
            }
            return ans;
        }


    }
}
