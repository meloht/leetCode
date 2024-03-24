using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.树状数组
{
    public class BinaryIndexedTreeTemplate
    {
        /// <summary>
        /// 树状数组
        /// </summary>
        public class NumArray
        {
            private int[] tree;
            private int[] nums;
            public NumArray(int[] nums)
            {
                this.nums = nums;
                tree = new int[nums.Length + 1];
                for (int i = 0; i < nums.Length; i++)
                {
                    Add(i + 1, nums[i]);
                }


            }
            private void Add(int index, int val)
            {
                while (index < tree.Length)
                {
                    tree[index] += val;
                    index += LowBit(index);
                }
            }

            public void Update(int index, int val)
            {
                Add(index + 1, val - nums[index]);
                nums[index] = val;
            }

            public int SumRange(int left, int right)
            {
                return PrefixSum(right + 1) - PrefixSum(left);
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
