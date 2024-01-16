using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2719_CountOfIntegersAlg
    {
        public int Count(string num1, string num2, int min_sum, int max_sum)
        {



            return 0;
        }
        private int CompareNum(string num1, string num2)
        {
            if (num1.Length > num2.Length)
            {
                return 1;
            }
            else if (num1.Length < num2.Length)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < num1.Length; i++)
                {
                    if (num1[i] != num2[i])
                    {
                        if (num1[i] > num2[i])
                            return 1;
                        if (num1[i] < num2[i])
                            return -1;
                    }
                }
                return 0;
            }
        }
        private int CountNumbers(string num,int minSum,int maxSum)
        {
            int[,,] dp=new int[]
            return 0;
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

        static void Main()
        {
            int A = 100;
            int B = 500;
            int targetSum = 5;

            int result = CountNumbersWithDigitSum(A, B, targetSum);

            Console.WriteLine($"在范围 [{A}, {B}] 内，数位之和为 {targetSum} 的数字个数为：{result}");
        }
    }
}
