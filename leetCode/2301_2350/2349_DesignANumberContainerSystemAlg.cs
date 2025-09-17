﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2301_2350
{
    public class _2349_DesignANumberContainerSystemAlg
    {
        public class NumberContainers
        {
            private Dictionary<int, int> nums = new();
            private Dictionary<int, PriorityQueue<int, int>> heaps = new();

            public void Change(int index, int number)
            {
                nums[index] = number;
                if (!heaps.ContainsKey(number))
                {
                    heaps[number] = new PriorityQueue<int, int>();
                }
                heaps[number].Enqueue(index, index);
            }

            public int Find(int number)
            {
                if (!heaps.ContainsKey(number))
                {
                    return -1;
                }
                var heap = heaps[number];
                while (heap.Count > 0 && nums[heap.Peek()] != number)
                {
                    heap.Dequeue();
                }
                return heap.Count == 0 ? -1 : heap.Peek();
            }
        }
    }
}
