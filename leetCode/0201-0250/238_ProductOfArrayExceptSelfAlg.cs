using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _238_ProductOfArrayExceptSelfAlg
    {
        public int[] ProductExceptSelf1(int[] nums)
        {
            int n = nums.Length;

            int[] perfix = new int[n];
            int[] suffix = new int[n];
            perfix[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                perfix[i] = nums[i] * perfix[i - 1];
            }
            suffix[n - 1] = nums[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i];
            }
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    result[i] = suffix[i + 1];
                }
                else if (i == n - 1)
                {
                    result[i] = perfix[i - 1];
                }
                else
                {
                    result[i] = perfix[i - 1] * suffix[i + 1];
                }

            }

            return result;
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            result[0] = 1;
            for (int i = 1; i < n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int r = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] = result[i] * r;
                r = r * nums[i];
            }
            return result;
        }
    }
}
