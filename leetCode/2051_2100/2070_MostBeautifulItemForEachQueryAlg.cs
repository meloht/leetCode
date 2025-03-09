﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2051_2100
{
    public class _2070_MostBeautifulItemForEachQueryAlg
    {
        public int[] MaximumBeauty(int[][] items, int[] queries)
        {
            // 将物品按价格升序排序
            Array.Sort(items, (a, b) => a[0].CompareTo(b[0]));
            int n = items.Length;
            // 按定义修改美丽值
            for (int i = 1; i < n; ++i)
            {
                items[i][1] = Math.Max(items[i][1], items[i - 1][1]);
            }
            // 二分查找处理查询
            int[] res = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                res[i] = Query(items, queries[i]);
            }
            return res;

        }

        private int Query(int[][] items, int q)
        {
            int l = 0, r = items.Length;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (items[mid][0] > q)
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            if (l == 0)
            {
                // 此时所有物品价格均大于查询价格
                return 0;
            }
            else
            {
                // 返回小于等于查询价格的物品的最大美丽值
                return items[l - 1][1];
            }
        }

    }
}
