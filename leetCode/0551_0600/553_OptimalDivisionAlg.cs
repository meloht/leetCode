using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _553_OptimalDivisionAlg
    {
        public string OptimalDivision(int[] nums)
        {
            int n = nums.Length;
            if (n == 1)
            {
                return nums[0].ToString();
            }
            if (n == 2)
            {
                return nums[0].ToString() + "/" + nums[1].ToString();
            }
            StringBuilder res = new StringBuilder();
            res.Append(nums[0]);
            res.Append("/(");
            res.Append(nums[1]);
            for (int i = 2; i < n; i++)
            {
                res.Append("/");
                res.Append(nums[i]);
            }
            res.Append(")");
            return res.ToString();

        }
    }
}
