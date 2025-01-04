﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _732_MyCalendarIIIAlg
    {
        public class MyCalendarThree
        {
            Dictionary<int, int[]> tree;
            public MyCalendarThree()
            {
                tree = new Dictionary<int, int[]>();
            }

            public int Book(int startTime, int endTime)
            {
                Update(startTime, endTime - 1, 1, 0, 1000000000, 1);
        
                return tree[1][0];
            }

            public void Update(int start, int end, int val, int l, int r, int idx)
            {
                if (r < start || end < l)
                {
                    return;
                }
                if (!tree.ContainsKey(idx))
                {
                    tree.Add(idx, new int[2]);
                }
                if (start <= l && r <= end)
                {
                    tree[idx][0] += val;
                    tree[idx][1] += val;
                }
                else
                {
                    int mid = (l + r) >> 1;
                    Update(start, end, val, l, mid, 2 * idx);
                    Update(start, end, val, mid + 1, r, 2 * idx + 1);
                    if (!tree.ContainsKey(2 * idx))
                    {
                        tree.Add(2 * idx, new int[2]);
                    }
                    if (!tree.ContainsKey(2 * idx + 1))
                    {
                        tree.Add(2 * idx + 1, new int[2]);
                    }
                    tree[idx][0] = tree[idx][1] + Math.Max(tree[2 * idx][0], tree[2 * idx + 1][0]);
                }
            }
        }
    }
}
