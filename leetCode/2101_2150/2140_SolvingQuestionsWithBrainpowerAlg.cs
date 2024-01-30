using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2140_SolvingQuestionsWithBrainpowerAlg
    {
        public long MostPoints1(int[][] questions)
        {
            long[] dp = new long[questions.Length];
            Array.Fill(dp, -1);
            long ans = Dfs(0, dp, questions);
            return ans;
        }

        private long Dfs(int index, long[] dp, int[][] questions)
        {
            if (index >= questions.Length)
                return 0;
            if (dp[index] != -1)
            {
                return dp[index];
            }
            long skip = Dfs(index + 1, dp, questions);

            int[] arr = questions[index];
            long choose = Dfs(index + arr[1] + 1, dp, questions) + arr[0];

            long ans = Math.Max(skip, choose);
            dp[index] = ans;
            return ans;

        }

        public long MostPoints(int[][] questions)
        {
            long[] dp = new long[questions.Length + 1];

            for (int i = questions.Length - 1; i >= 0; i--)
            {
                int index = Math.Min(questions.Length, i + questions[i][1] + 1);
                dp[i] = Math.Max(dp[i + 1], questions[i][0] + dp[index]);
            }
            return dp[0];
        }
    }
}
