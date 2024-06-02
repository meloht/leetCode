using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1521_FindAValueOfAMysteriousFunctionClosestToTargetAlg
    {
        public int ClosestToTarget(int[] arr, int target)
        {
            int ans = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int x = arr[i];
                ans = Math.Min(ans, Math.Abs(x - target));
                for (int j = i - 1; j >= 0 && (arr[j] & x) != arr[j]; j--)
                {
                    arr[j] &= x;
                    ans = Math.Min(ans, Math.Abs(arr[j] - target));
                }
            }

            return ans;
        }
    }
}
