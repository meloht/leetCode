using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1399_CountLargestGroupAlg
    {
        public int CountLargestGroup1(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sum = 0;

                while (num > 0)
                {
                    int d = num % 10;
                    sum += d;
                    num /= 10;
                }
                if (dict.ContainsKey(sum))
                {
                    dict[sum]++;
                }
                else
                {
                    dict.Add(sum, 1);
                }
                max = Math.Max(max, dict[sum]);
            }

            int ans = 0;

            foreach (var item in dict)
            {
                if (item.Value == max)
                {
                    ans++;
                }
            }

            return ans;
        }

        public int CountLargestGroup(int n)
        {
            char[] s = n.ToString().ToCharArray();
            int m = s.Length;
            int[][] memo = new int[m][];
            for (int i = 0; i < m; i++)
            {
                int[] arr = new int[m * 9 + 1];
                Array.Fill(arr, -1);
                memo[i] = arr;
            }
            int maxCnt = 0;
            int ans = 0;
            for (int target = 1; target <= m * 9; target++)
            { // 枚举目标数位和
                int cnt = Dfs(0, target, true, s, memo);
                if (cnt > maxCnt)
                {
                    maxCnt = cnt;
                    ans = 1;
                }
                else if (cnt == maxCnt)
                {
                    ans++;
                }
            }



            return ans;
        }
        private int Dfs(int i, int left, bool limitHigh, char[] s, int[][] memo)
        {
            if (i == s.Length)
            {
                return left == 0 ? 1 : 0;
            }
            if (!limitHigh && memo[i][left] != -1)
            {
                return memo[i][left];
            }

            int hi = limitHigh ? s[i] - '0' : 9; // 当前数位至多填 hi
            int res = 0;
            for (int d = 0; d <= Math.Min(hi, left); d++)
            { // 枚举当前数位填 d
                res += Dfs(i + 1, left - d, limitHigh && d == hi, s, memo);
            }

            if (!limitHigh)
            {
                memo[i][left] = res;
            }
            return res;
        }
    }
}
