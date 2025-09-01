﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1104_PathInZigzagLabelledBinaryTreeAlg
    {
        public IList<int> PathInZigZagTree(int label)
        {
            int row = 1, rowStart = 1;
            while (rowStart * 2 <= label)
            {
                row++;
                rowStart *= 2;
            }
            if (row % 2 == 0)
            {
                label = GetReverse(label, row);
            }
            IList<int> path = new List<int>();
            while (row > 0)
            {
                if (row % 2 == 0)
                {
                    path.Add(GetReverse(label, row));
                }
                else
                {
                    path.Add(label);
                }
                row--;
                label >>= 1;
            }
            path = new List<int>(path.Reverse());
            return path;
        }

        public int GetReverse(int label, int row)
        {
            return (1 << row - 1) + (1 << row) - 1 - label;
        }


    }
}
