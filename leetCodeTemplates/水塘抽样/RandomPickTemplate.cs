using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.水塘抽样
{
    internal class RandomPickTemplate
    {
        public int Pick(int target,int[] nums)
        {
            Random random=new Random();
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
