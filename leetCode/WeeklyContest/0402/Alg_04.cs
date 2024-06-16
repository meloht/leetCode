using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0402
{
    public class Alg_04
    {
        public IList<int> CountOfPeaks(int[] nums, int[][] queries)
        {
            int n = nums.Length;

            TreeArray treeArray = new TreeArray(n);
            for (int i = 1; i < n - 1; i++)
            {
                Update(treeArray, nums, i, 1);
            }

            List<int> ans = new List<int>();

            foreach (var item in queries)
            {
                if (item[0] == 1)
                {
                    ans.Add(treeArray.SumRange(item[1] + 1, item[2] - 1));
                    continue;
                }
                int i = item[1];
                for (int j = Math.Max(i - 1, 1); j <= Math.Min(i + 1, n - 2); j++)
                {
                    Update(treeArray, nums, j, -1);
                }
                nums[i] = item[2];

                for (int j = Math.Max(i - 1, 1); j <= Math.Min(i + 1, n - 2); j++)
                {
                    Update(treeArray, nums, j, 1);
                }
            }

            return ans;
        }
        private void Update(TreeArray treeArray, int[] nums, int i, int val)
        {
            if (nums[i - 1] < nums[i] && nums[i] > nums[i + 1])
            {
                treeArray.Update(i, val);
            }
        }

        public class TreeArray
        {
            private int[] tree;
            public TreeArray(int n)
            {
                tree = new int[n];
            }


            public void Update(int index, int val)
            {
                while (index < tree.Length)
                {
                    tree[index] += val;
                    index += LowBit(index);
                }
            }

            public int SumRange(int left, int right)
            {
                if (right < left)
                    return 0;

                return PrefixSum(right) - PrefixSum(left - 1);
            }
            private int PrefixSum(int index)
            {
                int sum = 0;
                while (index > 0)
                {
                    sum += tree[index];
                    index -= LowBit(index);
                }
                return sum;
            }

            private int LowBit(int x)
            {
                return x & (-x);
            }
        }
    }
}
