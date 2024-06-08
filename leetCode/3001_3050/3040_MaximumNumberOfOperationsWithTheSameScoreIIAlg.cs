using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3040_MaximumNumberOfOperationsWithTheSameScoreIIAlg
    {
        public int MaxOperations(int[] nums)
        {
            int[][] dict = new int[nums.Length][];
            for (int i = 0; i < nums.Length; i++)
            {
                dict[i] = new int[nums.Length];
            }

            int n1 = Compute(nums, 2, nums.Length - 1, nums[0] + nums[1], dict);


            int n2 = Compute(nums, 1, nums.Length - 2, nums[0] + nums[nums.Length - 1], dict);


            int n3 = Compute(nums, 0, nums.Length - 3, nums[nums.Length - 2] + nums[nums.Length - 1], dict);


            int ans = Math.Max(n1, n2);
            ans = Math.Max(ans, n3);
            return ans;
        }
        private int Compute(int[] nums, int begin, int end, int total, int[][] dict)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                Array.Fill(dict[i], -1);
            }

            return Dfs(nums, begin, end, total, dict) + 1;

        }

        private int Dfs(int[] nums, int begin, int end, int total, int[][] dict)
        {
            if (end - begin + 1 < 2)
                return 0;
            if (dict[begin][end] != -1)
            {
                return dict[begin][end];
            }
            int n1 = 0;
            if (nums[begin] + nums[begin + 1] == total)
            {
                n1 = Dfs(nums, begin + 2, end, total, dict) + 1;
            }
            int n2 = 0;
            if (nums[begin] + nums[end] == total)
            {

                n2 = Dfs(nums, begin + 1, end - 1, total, dict) + 1;
            }
            int n3 = 0;
            if (nums[end - 1] + nums[end] == total)
            {
                n3 = Dfs(nums, begin, end - 2, total, dict) + 1;
            }
            int ans = Math.Max(n1, n2);
            ans = Math.Max(ans, n3);
            dict[begin][end] = ans;

            return ans;
        }
    }
}
