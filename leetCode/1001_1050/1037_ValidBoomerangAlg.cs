using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1037_ValidBoomerangAlg
    {
        public bool IsBoomerang(int[][] points)
        {
            HashSet<string> set = new HashSet<string>();
            foreach (int[] point in points)
            {
                set.Add($"{point[0]}-{point[1]}");
            }
            if (set.Count < 3)
                return false;
            var a = GetXY(points[0][0], points[0][1], points[1][0], points[1][1]);
            var b = GetXY(points[1][0], points[1][1], points[2][0], points[2][1]);

            if (a == b)
                return false;



            return true;
        }

        private double GetXY(int a, int b, int x, int y)
        {
            double aa = x - a;
            double bb = y - b;

            if (aa == 0)
                return double.MinValue;

            return bb / aa;
        }
        /// <summary>
        /// 计算从 points[0]\textit{points}[0]points[0] 开始，分别指向 points[1]\textit{points}[1]points[1] 和 points[2]\textit{points}[2]points[2] 的向量 v⃗1\vec{v}_1 v 1 ​ 和 v⃗2\vec{v}_2 v 2 ​ 。
        /// 「三点各不相同且不在一条直线上」等价于「这两个向量的叉乘结果不为0
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public bool IsBoomerang1(int[][] points)
        {
            int[] v1 = { points[1][0] - points[0][0], points[1][1] - points[0][1] };
            int[] v2 = { points[2][0] - points[0][0], points[2][1] - points[0][1] };
            return v1[0] * v2[1] - v1[1] * v2[0] != 0;
        }


    }
}
