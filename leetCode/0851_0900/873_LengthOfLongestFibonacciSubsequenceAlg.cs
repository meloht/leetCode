using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _873_LengthOfLongestFibonacciSubsequenceAlg
    {
        int ans = 0;
        public int LenLongestFibSubseq1(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                dict.Add(arr[i], i);
            }
            bool[,] dp = new bool[arr.Length, arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nn = arr[i] + arr[j];
                    if (dict.ContainsKey(nn))
                    {
                        ans = Math.Max(ans, 3);
                        int idx = dict[nn];
                        Dfs(arr, j, idx, 3, dict, dp);
                    }

                }

            }

            return ans;
        }

        private void Dfs(int[] arr, int prev, int idx, int len, Dictionary<int, int> dict, bool[,] dp)
        {
            if (idx == arr.Length - 1)
            {
                return;
            }
            if (dp[prev, idx])
            {
                return;
            }
            dp[prev, idx] = true;
            int nn = arr[prev] + arr[idx];
            if (dict.ContainsKey(nn))
            {
                ans = Math.Max(ans, len + 1);
                Dfs(arr, idx, dict[nn], len + 1, dict, dp);
            }
        }

        public int LenLongestFibSubseq(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                dict.Add(arr[i], i);
            }
            int n = arr.Length;
            int[,] dp = new int[n, n];


            int res = 0;
            for (int i = 0; i < n; i++)
            {
                int num1 = arr[i];
                for (int j = i - 1; j >= 0 && arr[j] * 2 > arr[i]; j--)
                {
                    int nn = arr[i] - arr[j];

                    if (dict.ContainsKey(nn))
                    {
                        int k = dict[nn];
                        dp[j, i] = Math.Max(dp[k, j] + 1, 3);
                        res = Math.Max(res, dp[j, i]);
                    }
                }
            }

            return res;
        }
    }
}
