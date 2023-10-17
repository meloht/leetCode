using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class NextPermutationAlg
    {
        public void NextPermutation(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
                return;

            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }
            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[i] >= nums[j])
                {
                    j--;
                }
                Swap(nums, i, j);
            }

            int index = i + 1;

            List<int> list = new List<int>();
            for (int n = index; n < nums.Length; n++)
            {
                list.Add(nums[n]);
            }

            list.Sort();
            for (int n = index; n < nums.Length; n++)
            {
                nums[n] = list[n - index];
            }
        }

        private bool isEnd(int[] nums)
        {
            List<int> sortList = nums.ToList();

            sortList.Sort();

            List<int> reverseList = new List<int>(sortList);
            reverseList.Reverse();
            if (reverseList.SequenceEqual(nums.ToList()))
            {
                Array.Reverse(nums);
                return true;
            }
            return false;
        }
        private void Swap(int[] num, int i, int j)
        {
            int temp = num[i];
            num[i] = num[j];
            num[j] = temp;
        }
        private void Insert(int beginIndex, int endIndex, int[] nums)
        {
            for (int i = endIndex; i > beginIndex; i--)
            {
                Swap(nums, i, i - 1);
            }
        }

    }
}
