using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _123_BestTimeToBuyAndSellStockIIIAlg
    {
        public int MaxProfit1(int[] prices)
        {
            int[,] dp = new int[prices.Length, prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    dp[i, j] = Math.Max(prices[j] - prices[i], dp[i, j - 1]);
                    dp[0, j] = Math.Max(dp[i, j], dp[0, j]);
                }

            }
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                max = Math.Max(max, dp[0, i] + dp[i, prices.Length - 1]);
            }

            return max;
        }

        public int MaxProfit2(int[] prices)
        {
            int[] dpLeft = new int[prices.Length];
            int[] dpRight = new int[prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    dpRight[i] = Math.Max(prices[j] - prices[i], dpRight[i]);
                    dpLeft[j] = Math.Max(dpRight[i], dpLeft[j]);
                }

            }
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                max = Math.Max(max, dpLeft[i] + dpRight[i]);
            }

            return max;
        }

        public int MaxProfit(int[] prices)
        {
            List<int> lowList = GetMinList(prices);
            List<int> peekList = GetPeekList(prices, lowList);

            int max = 0;

            var right = GetRightPeek(peekList, prices, lowList);
            var left = GetLeftPeek(peekList, prices, lowList);
            for (int i = 0; i < left.Length; i++)
            {
                int leftNum = left[i];
                int rightNum = 0;
                if (i + 1 < left.Length)
                {
                    rightNum = right[i + 1];
                }
                max = Math.Max(max, rightNum + leftNum);
            }
            return max;
        }

        private List<int> GetMinList(int[] prices)
        {
            List<int> lowList = new List<int>();

            int index = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                int current = prices[i - 1];
                int next = prices[i];
                if (next > current)
                {
                    if (index != -1 || index == 0)
                    {
                        lowList.Add(index);

                        index = -1;
                    }
                }
                else if (next < current)
                {
                    index = i;
                }
            }
            return lowList;
        }

        private List<int> GetPeekList(int[] prices, List<int> lowList)
        {
            List<int> peekList = new List<int>();
            for (int i = 1; i <= lowList.Count; i++)
            {
                int begin = lowList[i - 1];
                int end = 0;
                if (i == lowList.Count)
                {
                    end = prices.Length;
                }
                else
                {
                    end = lowList[i];
                }
                int maxNum = 0;
                int maxIndex = 0;

                for (int j = begin; j < end; j++)
                {
                    if (prices[j] > maxNum)
                    {
                        maxNum = prices[j];
                        maxIndex = j;
                    }
                }
                peekList.Add(maxIndex);
            }
            return peekList;
        }
        private int[] GetRightPeek(List<int> peekList, int[] prices, List<int> lowList)
        {
            int[] dp = new int[lowList.Count];
            if (lowList.Count == 0)
                return dp;

            dp[lowList.Count - 1] = prices[peekList[peekList.Count - 1]] - prices[lowList[lowList.Count - 1]];
            int max = prices[peekList[peekList.Count - 1]];
            for (int i = lowList.Count - 2; i >= 0; i--)
            {
                max = Math.Max(prices[peekList[i]], max);
                dp[i] = Math.Max(dp[i + 1], max - prices[lowList[i]]);
            }
            return dp;
        }

        private int[] GetLeftPeek(List<int> peekList, int[] prices, List<int> lowList)
        {
            int[] dp = new int[lowList.Count];
            if (lowList.Count == 0)
                return dp;

            dp[0] = prices[peekList[0]] - prices[lowList[0]];

            int min = prices[lowList[0]];
            for (int i = 1; i < lowList.Count; i++)
            {
                min = Math.Min(min, prices[lowList[i]]);
                dp[i] = Math.Max(prices[peekList[i]] - min, dp[i - 1]);
            }
            return dp;
        }

    }
}
