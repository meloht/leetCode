using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _413_ArithmeticSlicesAlg
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            if (nums.Length ==1)
            {
                return 0;
            }
            int ans = 0;
            int dis = int.MaxValue;
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                int pre=nums[i-1];
                int curr=nums[i];
                if (dis == int.MaxValue)
                {
                    dis = curr - pre;
                    count = 2;
                }
                else
                {
                    if (curr - pre == dis)
                    {
                        count++;
                    }
                    else
                    {
                        ans += GetCount(count);
                        dis= curr - pre;
                        count = 2;
                    }
                }
               
            }
            ans += GetCount(count);
            return ans;
        }
        private int GetCount(int len)
        {
            int count = 0;
            for (int i = 3; i <= len; i++)
            {
                count += (len - i + 1);
            }
            return count;
        }

        public int NumberOfArithmeticSlices1(int[] nums)
        {
            int n = nums.Length;
            if (n == 1)
            {
                return 0;
            }

            int d = nums[0] - nums[1], t = 0;
            int ans = 0;
            // 因为等差数列的长度至少为 3，所以可以从 i=2 开始枚举
            for (int i = 2; i < n; ++i)
            {
                if (nums[i - 1] - nums[i] == d)
                {
                    ++t;
                }
                else
                {
                    d = nums[i - 1] - nums[i];
                    t = 0;
                }
                ans += t;
            }
            return ans;
        }


    }
}
