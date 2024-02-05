using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _452_MinimumNumberOfArrowsToBurstBalloonsAlg
    {
        public int FindMinArrowShots(int[][] points)
        {
            var arr = points.OrderBy(p => p[0]).ToArray();

            int count = 0;
            int i = 0;
            while (i < arr.Length)
            {
                int begin = arr[i][0];
                int end = arr[i][1];
                int next = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int begin2 = arr[j][0];
                    int end2 = arr[j][1];
                    next = j;
                    if (end >= begin2)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (next != 0)
                {
                    i = next;
                }
                else
                {
                    i++;
                }
              
            }

            int ans = points.Length - count;
            return ans;
        }
    }
}
