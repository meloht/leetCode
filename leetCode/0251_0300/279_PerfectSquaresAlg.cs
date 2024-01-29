using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _279_PerfectSquaresAlg
    {
        public int NumSquares1(int n)
        {
            int[] dp = new int[n + 1];
          
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = i;
            }

            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i * i <= j; i++)
                {
                    int num = i * i;
                    dp[j] = Math.Min(dp[j], dp[j - num] + 1);
                }
            }

            return dp[n];
        }

        public int NumSquares2(int n)
        {
            int[] f = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                int minn = int.MaxValue;
                for (int j = 1; j * j <= i; j++)
                {
                    minn = Math.Min(minn, f[i - j * j]);
                }
                f[i] = minn + 1;
            }
            return f[n];
        }
        /// <summary>
        /// 四平方和定理证明了任意一个正整数都可以被表示为至多四个正整数的平方和
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumSquares(int n)
        {
            if (IsPerfectSquare(n))
            {
                return 1;
            }
            if (CheckAnswer4(n))
            {
                return 4;
            }
            for (int i = 1; i * i <= n; i++)
            {
                int j = n - i * i;
                if (IsPerfectSquare(j))
                {
                    return 2;
                }
            }
            return 3;
        }

        // 判断是否为完全平方数
        public bool IsPerfectSquare(int x)
        {
            int y = (int)Math.Sqrt(x);
            return y * y == x;
        }

        // 判断是否能表示为 4^k*(8m+7)
        public bool CheckAnswer4(int x)
        {
            while (x % 4 == 0)
            {
                x /= 4;
            }
            return x % 8 == 7;
        }



    }
}
