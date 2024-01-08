using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0441_0450
{
    public class _447_NumberOfBoomerangsAlg
    {
        public int NumberOfBoomerangs1(int[][] points)
        {
            List<int[]> numbers = new List<int[]>();

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    int[] arr = new int[4];

                    arr[0] = points[i][0];
                    arr[1] = points[i][1];
                    arr[2] = points[j][0];
                    arr[3] = points[j][1];

                    numbers.Add(arr);
                }
            }
            int count = 0;
            foreach (int[] arr in numbers)
            {
                foreach (int[] point in points)
                {
                    if (point[0] == arr[0] && point[1] == arr[1])
                        continue;
                    if (point[0] == arr[2] && point[1] == arr[3])
                        continue;

                    long dis1 = GetDis(point[0], point[1], arr[0], arr[1]);
                    long dis2 = GetDis(point[0], point[1], arr[2], arr[3]);
                    if (dis1 == dis2)
                    {
                        count++;
                    }
                }
            }

            return count*2;
        }

        public int NumberOfBoomerangs(int[][] points)
        {
            int ans = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int[] p1 in points)
            {
                dict.Clear();
                foreach (int[] p2 in points)
                {
                    if (p1[0] == p2[0] && p1[1] == p2[1])
                        continue;

                    int dis = GetDis(p1[0], p1[1], p2[0], p2[1]);
                    if (dict.ContainsKey(dis))
                    {
                        ans += dict[dis] * 2;
                        dict[dis]++;
                    }
                    else
                    {
                        dict.Add(dis, 1);
                    }
                }
            }
            return ans;
        }

        private int GetDis(int a1, int b1, int a2, int b2)
        {
            int x1 = a1 - a2;
            int y1 = b1 - b2;

            int dis = x1 * x1 + y1 * y1;
            return dis;
        }


      

    }
}