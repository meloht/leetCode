using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _922_SortArrayByParityIIAlg
    {
        public int[] SortArrayByParityII1(int[] nums)
        {
            List<int> ls = new List<int>();
            List<int> ls2 = new List<int>();
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    ls.Add(item);
                }
                else
                {
                    ls2.Add(item);
                }
            }
            int n = 0;
            int m = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    nums[i] = ls[m];
                    m++;
                }
                else
                {
                    nums[i] = ls2[n];
                    n++;
                }
            }
            return nums;
        }

        public int[] SortArrayByParityII2(int[] nums)
        {

            for (int k = 0, j = 0, i = 0; k < nums.Length && j < nums.Length && i < nums.Length; k++)
            {
                if (k % 2 == 0)
                {
                    if (nums[k] % 2 == 1)
                    {
                        i = GetEvenIndex(i, nums);
                        Swap(nums, k, i);
                    }
                    else
                    {
                        i = GetEvenIndex(k + 1, nums);
                    }
                }
                else
                {
                    if (nums[k] % 2 == 0)
                    {
                        j = GetOddIndex(j, nums);
                        Swap(nums, k, j);
                    }
                    else
                    {
                        j = GetOddIndex(k + 1, nums);
                    }
                }
            }
            return nums;
        }
        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        private int GetOddIndex(int i, int[] nums)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[j] % 2 == 1)
                {
                    return j;
                }
            }
            return -1;
        }
        private int GetEvenIndex(int i, int[] nums)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[j] % 2 == 0)
                {
                    return j;
                }
            }
            return -1;
        }



        public int[] SortArrayByParityII(int[] nums)
        {
            int n = nums.Length;
            int j = 1;
            for (int i = 0; i < n; i += 2)
            {
                if (nums[i] % 2 == 1)
                {
                    while (nums[j] % 2 == 1)
                    {
                        j += 2;
                    }
                    Swap(nums, i, j);
                }
            }
            return nums;
        }

        


    }
}
