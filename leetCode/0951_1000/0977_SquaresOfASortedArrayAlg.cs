using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0977_SquaresOfASortedArrayAlg
    {
        public int[] SortedSquares(int[] nums)
        {
            List<int> list = new List<int>();
            List<int> res = new List<int>();
            foreach (var item in nums)
            {
                if (item < 0)
                {
                    list.Add(item * item);
                }
                else
                {
                    res.Add(item * item);
                }
            }
            if (res.Count == 0)
            {
                list.Reverse();
                return list.ToArray();
            }

            int j = 0;
            bool bl = false;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                bl = false;
                for (int k = j; k < res.Count; k++)
                {
                    if (res[k] <= list[i])
                    {
                        j = k;
                        bl = true;
                    }
                    else
                    {
                        break;
                    }
                }
                if (bl)
                {
                    j++;
                }
                res.Insert(j, list[i]);


            }
            return res.ToArray();
        }

        public int[] SortedSquares1(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n];
            for (int i = 0, j = n - 1, pos = n - 1; i <= j;)
            {
                if (nums[i] * nums[i] > nums[j] * nums[j])
                {
                    ans[pos] = nums[i] * nums[i];
                    ++i;
                }
                else
                {
                    ans[pos] = nums[j] * nums[j];
                    --j;
                }
                --pos;
            }
            return ans;
        }

        public int[] SortedSquares2(int[] nums)
        {
            int n = nums.Length;
            int negative = -1;

            for (int k = 0; k < n; ++k)
            {
                if (nums[k] < 0)
                {
                    negative = k;
                }
                else
                {
                    break;
                }
            }

            int[] ans = new int[n];
            int index = 0, i = negative, j = negative + 1;
            while (i >= 0 || j < n)
            {
                if (i < 0)
                {
                    ans[index] = nums[j] * nums[j];
                    ++j;
                }
                else if (j == n)
                {
                    ans[index] = nums[i] * nums[i];
                    --i;
                }
                else if (nums[i] * nums[i] < nums[j] * nums[j])
                {
                    ans[index] = nums[i] * nums[i];
                    --i;
                }
                else
                {
                    ans[index] = nums[j] * nums[j];
                    ++j;
                }
                ++index;
            }

            return ans;
        }




    }
}
