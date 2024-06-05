using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3072_DistributeElementsIntoTwoArraysIIAlg
    {
        public int[] ResultArray(int[] nums)
        {
            List<int> arr1 = [nums[0]];
            List<int> arr2 = [nums[1]];

            List<int> arr11 = [nums[0]];
            List<int> arr22 = [nums[1]];

            for (int i = 2; i < nums.Length; i++)
            {
                int num1 = GreaterCountVal(arr11, nums[i]);
                int count1 = arr11.Count - num1;

                int num2 = GreaterCountVal(arr22, nums[i]);
                int count2 = arr22.Count - num2;
                if (count1 > count2)
                {
                    arr1.Add(nums[i]);
                    InsertVal(arr11, num1, nums[i]);
                }
                else if (count1 < count2)
                {
                    arr2.Add(nums[i]);
                    InsertVal(arr22, num2, nums[i]);
                }
                else
                {
                    if (arr1.Count > arr2.Count)
                    {
                        arr2.Add(nums[i]);
                        InsertVal(arr22, num2, nums[i]);
                    }
                    else
                    {
                        arr1.Add(nums[i]);
                        InsertVal(arr11, num1, nums[i]);
                    }

                }
            }
            arr1.AddRange(arr2);
            return arr1.ToArray();
        }


        public void InsertVal(List<int> ls,int index,int val)
        {
            if (index > ls.Count - 1)
            {
                ls.Add(val);
            }
            else
            {
                ls.Insert(index, val);
            }
        }

        public int GreaterCountVal(List<int> arr1, int target)
        {
            int left = 0;
            int right = arr1.Count - 1;
            int ans = 0;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (arr1[mid] <= target)
                {
                    left = mid + 1;
                    ans = left;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return ans;
        }

    }
}
