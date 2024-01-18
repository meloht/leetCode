using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2719_CountOfIntegersAlg
    {
        int Mod = 1_000_000_007;
        public int Count1(string num1, string num2, int min_sum, int max_sum)
        {
            int n1 = Calculate(num2, min_sum, max_sum);
            int n2 = Calculate(num1, min_sum, max_sum);
            int ans = n1 - n2 + Mod;
            int sum = 0;
            foreach (char ch in num1)
            {
                sum += (ch - '0');
            }

            if (min_sum <= sum && sum <= max_sum)
            {
                ans++;
            }
            return ans % Mod;
        }

        private int Calculate(string s, int minNum, int maxNum)
        {
            int n = s.Length;
            int m = Math.Min(9 * n, maxNum) + 1;
            int[,] memo = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    memo[i, j] = -1;
                }
            }
            return Dfs(0, 0, true, s.ToCharArray(), minNum, maxNum, memo);
        }
        private int Dfs(int i, int sum, bool isLimit, char[] s, int minSum, int maxSum, int[,] memo)
        {
            if (sum > maxSum)
                return 0;

            if (i == s.Length)
            {
                return sum >= minSum ? 1 : 0;
            }
            if (!isLimit && memo[i, sum] != -1)
            {
                return memo[i, sum];
            }
            int up = isLimit ? s[i] - '0' : 9;
            int res = 0;
            for (int j = 0; j <= up; j++)
            {
                res = (res + Dfs(i + 1, sum + j, isLimit && (j == up), s, minSum, maxSum, memo)) % Mod;
            }
            if (!isLimit)
            {
                memo[i, sum] = res;
            }
            return res;
        }

        public int Count(string num1, string num2, int min_sum, int max_sum)
        {
            int n = num2.Length;
            num1 = num1.PadLeft(num2.Length,'0'); // 补前导零，和 num2 对齐

            int m = Math.Min(9 * n, max_sum) + 1;
            int[,] memo = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    memo[i, j] = -1;
                }
            }
            int ans = Dfs(0, 0, true, true, num1, num2, min_sum, max_sum, memo);
            return ans;
        }
        private int Dfs(int i, int sum, bool limitLow, bool limitHigh, string num1,string num2, int minNum, int maxNum, int[,] memo)
        {
            if (sum > maxNum)
                return 0;

            if (i == num2.Length)
            {
                return sum >= minNum ? 1 : 0;
            }
            if (!limitLow && !limitHigh && memo[i, sum] != -1)
            {
                return memo[i, sum];
            }
            int low = limitLow ? num1[i] - '0' : 0;
            int high = limitHigh ? num2[i] - '0' : 9;
            int res = 0;
            for (int j = low; j <= high; j++)
            {
                res = (res + Dfs(i + 1, sum + j, limitLow && j == low, limitHigh 
                    && j == high, num1, num2, minNum, maxNum, memo)) % Mod;
            }

            if (!limitHigh && !limitLow)
            {
                memo[i, sum] = res;
            }
            return res;
        }


        static int[,,] dp;
        static int CountNumbersWithDigitSum(int pos, int sum, bool isLimited, string limitStr)
        {
            if (pos == -1)
            {
                return sum == 0 ? 1 : 0;
            }

            if (!isLimited && dp[pos, sum, 0] != -1)
            {
                return dp[pos, sum, 0];
            }

            int limit = isLimited ? int.Parse(limitStr[pos].ToString()) : 9;
            int count = 0;

            for (int digit = 0; digit <= limit; digit++)
            {
                count += CountNumbersWithDigitSum(pos - 1, sum - digit, isLimited && digit == limit, limitStr);
            }

            if (!isLimited)
            {
                dp[pos, sum, 0] = count;
            }

            return count;
        }

        static int CountNumbersWithDigitSum(int A, int B, int targetSum)
        {
            string strA = (A - 1).ToString();
            string strB = B.ToString();

            int lenB = strB.Length;
            dp = new int[lenB, targetSum + 1, 1];

            for (int i = 0; i < lenB; i++)
            {
                for (int j = 0; j <= targetSum; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        dp[i, j, k] = -1;
                    }
                }
            }

            int result = CountNumbersWithDigitSum(lenB - 1, targetSum, true, strB) -
                         CountNumbersWithDigitSum(lenB - 1, targetSum, true, strA);

            return result;
        }


    }
}
