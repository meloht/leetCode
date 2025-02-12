﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.位运算.logTrick
{
    public class Template
    {
        public int[] LogTrick(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n];
            List<int[]> ors = new List<int[]>(); // 按位或的值 + 对应子数组的右端点的最小值

            for (int i = n - 1; i >= 0; i--)
            {
                ors.Add([0, i]);
                int k = 0;
                for (int j = 0; j < ors.Count; j++)
                {
                    var item = ors[j];
                    item[0] |= nums[i];// 更新按位或的值
                    if (ors[k][0] == item[0])
                    {
                        ors[k][1] = item[1];// 合并相同值，下标取最小的
                    }
                    else
                    {
                        k++;
                        ors[k] = item;// 更新列表

                    }
                }
                ors.RemoveRange(k + 1, ors.Count - k - 1); // 删除多余的子数组
                ans[i] = ors[0][1] - i + 1;  // 计算最小子数组长度
            }


            return ans;
        }
    }
}
