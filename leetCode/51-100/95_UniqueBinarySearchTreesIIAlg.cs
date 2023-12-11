using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _95_UniqueBinarySearchTreesIIAlg
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            List<List<int?[]>> dp = new List<List<int?[]>>();
            dp.Add(new List<int?[]>() { });
            int?[] arr1 = { 1 };
            dp.Add(new List<int?[]>() { arr1 });

            List<int?[]> dp2 = new List<int?[]>();
            dp2.Add(new int?[] { 1, null, 2 });
            dp2.Add(new int?[] { 2, 1 });
            dp.Add(dp2);

            for (int i = 2; i <= n; i++)
            {
                List<int?[]> temp = new List<int?[]>();
                for (int j = 1; j <= i; j++)
                {
                    var left = dp[j - 1];
                    var right = dp[i - j];
                    if (j - 1 == i - j)
                    {
                       // temp
                    }
                }
            }


            return null;
        }

        private void Dfs(int?[] arr, Dictionary<string, List<int?[]>> dict)
        {
            if (arr.Length == 2)
            {
                var res = BuildList(arr[0], arr[1]);
                string key = $"{arr[0] - arr[1]}";
                dict.Add(key, res);
            }
            else
            {

            }
        }

        private List<int?[]> BuildList(int? a, int? b)
        {
            List<int?[]> dp = new List<int?[]>();
            dp.Add(new int?[] { a, null, b });
            dp.Add(new int?[] { b, a });
            return dp;
        }

    }
}
