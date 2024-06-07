using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _398_RandomPickIndexAlg
    {
        public class Solution
        {
            Random random = new Random();
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            public Solution(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(nums[i]))
                    {
                        dict[nums[i]].Add(i);
                    }
                    else
                    {
                        dict.Add(nums[i], [i]);
                    }
                }
            }

            public int Pick(int target)
            {
                var list = dict[target];
                int index=random.Next(list.Count);
                return list[index];
            }
        }

        /// <summary>
        /// 水塘抽样
        /// </summary>
        public class Solution1
        {
            int[] nums;
            Random random;

            public Solution1(int[] nums)
            {
                this.nums = nums;
                random = new Random();
            }

            public int Pick(int target)
            {
                int ans = 0;
                for (int i = 0, cnt = 0; i < nums.Length; ++i)
                {
                    if (nums[i] == target)
                    {
                        ++cnt; // 第 cnt 次遇到 target
                        if (random.Next(cnt) == 0)
                        {
                            ans = i;
                        }
                    }
                }
                return ans;
            }
        }



    }
}
