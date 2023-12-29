using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _189_RotateArrayAlg
    {
        public void Rotate1(int[] nums, int k)
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



        public void Rotate3(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            int count = gcd(k, n);
            for (int start = 0; start < count; ++start)
            {
                int current = start;
                int prev = nums[start];
                do
                {
                    int next = (current + k) % n;
                    int temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    current = next;
                } while (start != current);
            }
        }

        private int gcd(int x, int y)
        {
            return y > 0 ? gcd(y, x % y) : x;
        }


        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            reverse(nums, 0, nums.Length - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, nums.Length - 1);
        }

        public void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start += 1;
                end -= 1;
            }
        }



    }
}
