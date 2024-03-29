﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _220_ContainsDuplicateIIIAlg
    {
        public bool ContainsNearbyAlmostDuplicate1(int[] nums, int indexDiff, int valueDiff)
        {
            List<DataModel> list = new List<DataModel>();

            for (int i = 0; i < nums.Length; i++)
            {
                list.Add(new DataModel(nums[i], i));
            }

            var ls = list.OrderBy(p => p.Value).ToList();
            int len = ls.Count;
            for (int i = 0; i < len; i++)
            {
                var curr = ls[i];

                for (int j = i + 1; j < len; j++)
                {
                    var next = ls[j];
                    int diff = Math.Abs(curr.Value - next.Value);
                    if (diff > valueDiff)
                        break;
                    int indff = Math.Abs(curr.Index - next.Index);
                    if (indff <= indexDiff)
                        return true;
                }
            }

            return false;

        }
        class DataModel
        {
            public int Value;
            public int Index;
            public DataModel(int val, int index)
            {
                this.Index = index;
                this.Value = val;
            }
        }

        long size;
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
        {
            int n = nums.Length;
            Dictionary<long, long> dict = new Dictionary<long, long>();
            size = valueDiff + 1L;
            for (int i = 0; i < n; i++)
            {
                long u = nums[i] * 1L;
                long idx = GetIdx(u);
                // 目标桶已存在（桶不为空），说明前面已有 [u - t, u + t] 范围的数字
                if (dict.ContainsKey(idx)) return true;
                // 检查相邻的桶
                long left = idx - 1, right = idx + 1;
                if (dict.ContainsKey(left) && u - dict[left] <= valueDiff) return true;
                if (dict.ContainsKey(right) && dict[right] - u <= valueDiff) return true;
                // 建立目标桶
               
                dict.TryAdd(idx, u);
                // 移除下标范围不在 [max(0, i - k), i) 内的桶
                if (i >= indexDiff) dict.Remove(GetIdx(nums[i - indexDiff] * 1L));
            }
            return false;

        }
        private long GetIdx(long u)
        {
            return u >= 0 ? u / size : ((u + 1) / size) - 1;
        }

    }
}
