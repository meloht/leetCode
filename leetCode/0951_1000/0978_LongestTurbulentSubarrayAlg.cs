using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0978_LongestTurbulentSubarrayAlg
    {
        public int MaxTurbulenceSize(int[] arr)
        {
            int n = arr.Length;
            int ret = 1;
            int left = 0, right = 0;

            while (right < n - 1)
            {
                if (left == right)
                {
                    if (arr[left] == arr[left + 1])
                    {
                        left++;
                    }
                    right++;
                }
                else
                {
                    if (arr[right - 1] < arr[right] && arr[right] > arr[right + 1])
                    {
                        right++;
                    }
                    else if (arr[right - 1] > arr[right] && arr[right] < arr[right + 1])
                    {
                        right++;
                    }
                    else
                    {
                        left = right;
                    }
                }
                ret = Math.Max(ret, right - left + 1);
            }
            return ret;

        }
    }
}
