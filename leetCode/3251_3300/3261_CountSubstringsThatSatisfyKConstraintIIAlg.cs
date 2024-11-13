using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3251_3300
{
    public class _3261_CountSubstringsThatSatisfyKConstraintIIAlg
    {
        public long[] CountKConstraintSubstrings(string s, int k, int[][] queries)
        {
            int n = s.Length;
            int[] right = new int[n];
            long[] sum = new long[n + 1];
            int[] cnt = new int[2];
            int l = 0;
            for (int i = 0; i < n; i++)
            {
                cnt[s[i] & 1]++;
                while (cnt[0] > k && cnt[1] > k)
                {
                    cnt[s[l] & 1]--;
                    right[l++] = i;
                }
                sum[i + 1] = sum[i] + i - l + 1;
            }
            // 剩余没填的 right[l] 均为 n
            Array.Fill(right, n, l, n - l);

            long[] ans = new long[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int ql = queries[i][0];
                int qr = queries[i][1];
                int j = Math.Min(right[ql], qr + 1);
                ans[i] = sum[qr + 1] - sum[j] + (long)(j - ql + 1) * (j - ql) / 2;
            }
            return ans;


        }
    }
}
