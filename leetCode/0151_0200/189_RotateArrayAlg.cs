using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _189_RotateArrayAlg
    {
        public void Rotate(int[] nums, int k)
        {
            int len = nums.Length;
            k = k % len;
            if (k == 0)
                return;
            List<int> list = new List<int>();

            int n = len - k;
            for (int i = 0; i < n; i++)
            {
                list.Add(nums[i]);
            }
            for (int i = n, j = 0; i < len; i++, j++)
            {
                nums[j] = nums[i];
            }

            for (int i = k, j = 0; i < len; i++, j++)
            {
                nums[i] = list[j];
            }
        }
    }
}
