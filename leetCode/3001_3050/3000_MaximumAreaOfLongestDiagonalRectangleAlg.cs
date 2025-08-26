using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3000_MaximumAreaOfLongestDiagonalRectangleAlg
    {
        public int AreaOfMaxDiagonal(int[][] dimensions)
        {

            int ans = 0;
            int max = 0;
            foreach (var item in dimensions)
            {
                int num = item[0] * item[0] + item[1] * item[1];
                if (num > max)
                {
                    max = num;
                    ans = item[0] * item[1];
                }
                else if (num == max)
                {
                    int a = item[0] * item[1];
                    if (a > ans)
                    {
                        ans = a;
                    }
                }
            }
            return ans;
        }
    }
}
