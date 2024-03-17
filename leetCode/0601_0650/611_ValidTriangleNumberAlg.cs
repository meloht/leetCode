using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _611_ValidTriangleNumberAlg
    {
        public int TriangleNumber1(int[] nums)
        {
            Array.Sort(nums);
            int ans = 0;
            int i = 0;
            int len = nums.Length - 2;
            int len1 = nums.Length - 1;
            while (i < len)
            {
                int n1 = nums[i];
                int j = i + 1;
                while (j < len1)
                {
                    int n2 = nums[j];
                    int nn = n1 + n2;

                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[k] < nn)
                        {
                            ans++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    j++;

                }

                i++;
            }
            return ans;
        }

        public int TriangleNumber(int[] nums)
        {
            Array.Sort(nums);
            int ans = 0;
            int i = 0;
            int len = nums.Length - 2;
            int len1 = nums.Length - 1;
            while (i < len)
            {
                int n1 = nums[i];
                int j = i + 1;
                while (j < len1)
                {
                    int n2 = nums[j];
                    int nn = n1 + n2;

                    int left = j + 1;
                    int right = nums.Length - 1;
                    int kk = j;
                    while (left <= right) 
                    {
                        int mid = (left + right) / 2;
                        if (nums[mid] < nn)
                        {
                            kk = mid;
                            left = mid + 1;
                        }
                        else
                        {
                            right = mid - 1;
                        }
                    }
                    ans += kk - j;

                    j++;

                }

                i++;
            }
            return ans;
        }
    }
}
