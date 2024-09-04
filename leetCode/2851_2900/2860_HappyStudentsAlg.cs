using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2851_2900
{
    public class _2860_HappyStudentsAlg
    {
        public int CountWays(IList<int> nums)
        {
            var arr = nums.ToArray();

            Array.Sort(arr);
            int ans = arr[0] > 0 ? 1 : 0; // 一个学生都不选

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < i && i < arr[i])
                {
                    ans++;
                }
            }

            return ans + 1;
        }
    }
}
