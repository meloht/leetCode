using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{
    public class _2848_PointsThatIntersectWithCarsAlg
    {
        public int NumberOfPoints(IList<IList<int>> nums)
        {
            var numArr = nums.ToArray();
            Array.Sort(numArr, (x, y) => x[0].CompareTo(y[0]));

            int ans = 0;
            int begin = numArr[0][0];
            int end = numArr[0][1];
            ans = end - begin + 1;
            for (int i = 1; i < numArr.Length; i++)
            {
                if (numArr[i][1] <= end)
                {
                    continue;
                }
                if (numArr[i][0] <= end)
                {
                    ans += numArr[i][1] - end;
                }
                else
                {
                    ans += numArr[i][1] - numArr[i][0] + 1;
                }

                begin = Math.Min(begin, numArr[i][0]);
                end = Math.Max(numArr[i][1], end);
            }


            return ans;
        }
    }
}
