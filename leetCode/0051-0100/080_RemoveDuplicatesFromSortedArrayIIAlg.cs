using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _80_RemoveDuplicatesFromSortedArrayIIAlg
    {
        public int RemoveDuplicates2(int[] nums)
        {
            int n = nums.Length;
            if (n <= 2)
            {
                return n;
            }
            int slow = 2, fast = 2;
            while (fast < n)
            {
                if (nums[slow - 2] != nums[fast])
                {
                    nums[slow] = nums[fast];
                    ++slow;
                }
                ++fast;
            }
            return slow;
        }

        public int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            int len = nums.Length;
            int count = 0;
            int index = 0;
            while (i < len)
            {
                int j = i + 1;
                count = 1;
                index = j;
                while (j < len)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                        index = j;
                    }
                    else
                    {
                        if (count <= 2)
                        {
                            i = j - 1;
                            break;
                        }
                        else
                        {
                            index = j;
                            break;
                        }
                    }
                    j++;
                }

                if (count > 2)
                {
                    int begin = index - (count - 2);
                    int end = len - (count - 2);
                    Swap(nums, begin, index, end, len);
                    len = len - (count - 2);
                    i = begin;
                }
                else
                {
                    i++;
                }

              
            }

            return len;
        }

        private void Swap(int[] nums, int begin, int nextIndex, int end, int len)
        {
            for (int i = begin, j = nextIndex; i < end && nextIndex < len; i++, j++)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
}
