using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _268_MissingNumberAlg
    {
        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int sum = (n + 1) * n / 2;
            int total = nums.Sum();
            int ans = sum - total;
            return ans;
        }
    }
}
