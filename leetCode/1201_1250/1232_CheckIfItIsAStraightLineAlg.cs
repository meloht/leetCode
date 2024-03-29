﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1201_1250
{
    public class _1232_CheckIfItIsAStraightLineAlg
    {
        public bool CheckStraightLine1(int[][] coordinates)
        {
            if (coordinates.Length <= 2)
                return true;

            int deltaX = coordinates[0][0], deltaY = coordinates[0][1];
            int n = coordinates.Length;
            for (int i = 0; i < n; i++)
            {
                coordinates[i][0] -= deltaX;
                coordinates[i][1] -= deltaY;
            }
            int A = coordinates[1][1], B = -coordinates[1][0];
            for (int i = 2; i < n; i++)
            {
                int x = coordinates[i][0], y = coordinates[i][1];
                if (A * x + B * y != 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 两点直线方程转换为乘法
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public bool CheckStraightLine(int[][] coordinates)
        {
            int m = coordinates.Length;
           
            int x = coordinates[0][0], y = coordinates[0][1];
            int k = coordinates[1][0] - x, v = coordinates[1][1] - y;
            for (int i = 2; i < m; i++)
            {
                if ((coordinates[i][0] - x) * v != (coordinates[i][1] - y) * k)
                    return false;
            }
            return true;
        }


    }
}
