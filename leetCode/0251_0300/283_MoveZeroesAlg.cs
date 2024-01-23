using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _283_MoveZeroesAlg
    {
        public void MoveZeroes1(int[] nums)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    list.Add(i);
                }
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                for (int j = list[i] + 1; j < nums.Length; j++)
                {
                    int temp = nums[j];
                    nums[j] = nums[j - 1];
                    nums[j - 1] = temp;
                }
            }

        }

        public void MoveZeroes(int[] nums)
        {
            int n = nums.Length;
            int left = 0;
            int right = 0;
            while (right < n)
            {
                if (nums[right] != 0)
                {
                    Swap(nums, left, right);
                    left++;
                }
                right++;
            }

           
        }
        private void Swap(int[] nums,int left,int right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }
    }
}
