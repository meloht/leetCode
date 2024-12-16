using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _646_MaximumLengthOfPairChainAlg
    {
        public int FindLongestChain(int[][] pairs)
        {
            Array.Sort(pairs, (x, y) => x[0].CompareTo(y[0]));
            int n = pairs.Length;
            int[,] memo = new int[n + 1, n + 1];

            int ans = Dfs(n - 2, n - 1, pairs, memo);

            return ans;
        }


        private int Dfs(int i, int j, int[][] pairs, int[,] memo)
        {
            if (i < 0)
            {
                return 1;
            }
            if (memo[i, j] != 0)
            {
                return memo[i, j];
            }
            int res = int.MinValue;
            if (pairs[i][1] < pairs[j][0])
            {
                res = Dfs(i - 1, i, pairs, memo) + 1;
            }

            int ans = Dfs(i - 1, j, pairs, memo);
            memo[i, j] = Math.Max(ans, res);
            return memo[i, j];
        }

        public int FindLongestChain1(int[][] pairs)
        {
            int n = pairs.Length;
            Array.Sort(pairs, (a, b) => a[0] - b[0]);
            int[] dp = new int[n];
            Array.Fill(dp, 1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (pairs[i][0] > pairs[j][1])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }
            return dp[n - 1];
        }

        public int FindLongestChain2(int[][] pairs)
        {
            Array.Sort(pairs, (a, b) => a[0] - b[0]);
            IList<int> arr = new List<int>();
            foreach (int[] p in pairs)
            {
                int x = p[0], y = p[1];
                if (arr.Count == 0 || x > arr[arr.Count - 1])
                {
                    arr.Add(y);
                }
                else
                {
                    int idx = BinarySearch(arr, x);
                    arr[idx] = Math.Min(arr[idx], y);
                }
            }
            return arr.Count;
        }

        public int BinarySearch(IList<int> arr, int x)
        {
            int low = 0, high = arr.Count - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] >= x)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }

        public int FindLongestChain3(int[][] pairs)
        {
            int curr = int.MinValue, res = 0;
            Array.Sort(pairs, (a, b) => a[1] - b[1]);
            foreach (int[] p in pairs)
            {
                if (curr < p[0])
                {
                    curr = p[1];
                    res++;
                }
            }
            return res;
        }



    }
}
