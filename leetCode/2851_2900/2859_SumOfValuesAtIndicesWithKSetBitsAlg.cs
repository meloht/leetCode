using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2851_2900
{
    public class _2859_SumOfValuesAtIndicesWithKSetBitsAlg
    {
        public int SumIndicesWithKSetBits1(IList<int> nums, int k)
        {
            if (k == 0)
                return nums[0];
            int ans = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                int count = 0;
                int num = i;
                while (num > 0)
                {
                    count += num & 1; // 按位与运算，检查最低位是否为1
                    num >>= 1;       // 右移一位，继续检查下一位
                }
                if (count == k)
                {
                    ans += nums[i];
                }
            }
            return ans;
        }

        public int SumIndicesWithKSetBits(IList<int> nums, int k)
        {
            if (k == 0)
                return nums[0];
            int ans = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                int count = Convert.ToString(i, 2).Count(p => p == '1');

                if (count == k)
                {
                    ans += nums[i];
                }
            }
            return ans;
        }
    }
}
