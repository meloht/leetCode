using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3095_ShortestSubarrayWithOrAtLeastKIAlg
    {
        public int MinimumSubarrayLength1(int[] nums, int k)
        {
            int ans = int.MaxValue;
            long sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum |= nums[j];
                    if (sum >= k)
                    {
                        ans = Math.Min(ans, j - i + 1);
                        if (ans == 1)
                            return ans;
                    }
                }
            }

            return ans == int.MaxValue ? -1 : ans;
        }

        public int MinimumSubarrayLength(int[] nums, int k)
        {
            int[] dict = new int[50];

            int ans = int.MaxValue;
            long sum = 0;
            int m = 0;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum |= nums[i];
                AddBinary(nums[i], dict);
                if (sum >= k)
                {
                    m = i;
                    ans = Math.Min(ans, i + 1);
                    break;
                }
            }
            if (ans == 1)
                return ans;

            SubBinary(nums[j], dict);
            j++;
            while (BinaryNum(dict) >= k)
            {
                ans = Math.Min(ans, m + 1 - j);
                if (ans == 1)
                    return ans;
                SubBinary(nums[j], dict);
                j++;
            }

            for (int i = m + 1; i < nums.Length; i++)
            {
                AddBinary(nums[i], dict);

                while (BinaryNum(dict) >= k && j <= i)
                {
                    ans = Math.Min(ans, i + 1 - j);
                    if (ans == 1)
                        return ans;
                    SubBinary(nums[j], dict);
                    j++;
                }
            }


            return ans == int.MaxValue ? -1 : ans;
        }

        public void AddBinary(int decimalNumber, int[] dict)
        {
            int i = 0;
            while (decimalNumber != 0)
            {
                if ((decimalNumber & 1) > 0)
                {
                    dict[i]++;
                }
                decimalNumber >>= 1;
                i++;
            }
        }

        public void SubBinary(int decimalNumber, int[] dict)
        {
            int i = 0;
            while (decimalNumber != 0)
            {
                if ((decimalNumber & 1) > 0)
                {
                    dict[i]--;
                }
                decimalNumber >>= 1;
                i++;
            }
        }

        public long BinaryNum(int[] dict)
        {
            long x = 0;

            int len = dict.Length - 1;
            for (int i = dict.Length - 1; i >= 0; i--)
            {
                if (dict[i] > 0)
                {
                    len = i;
                    break;
                }
            }
            for (int i = len; i >= 0; i--)
            {
                if (dict[i] > 0)
                {
                    x |= 1 << i;
                }
            }

            return x;
        }
    }
}
