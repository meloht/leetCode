using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _80_RemoveDuplicatesFromSortedArrayIIAlg
    {
        public int RemoveDuplicates(int[] nums)
        {

            int i = 0;
            int len = nums.Length;
            while (i < len)
            {

                int j = i + 1;
                int count = 1;

                while (j < len)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
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

                            int begin = j - (count - 2);
                            Swap(nums, begin, j, len);
                            len = len - (count - 2);
                            i = j - 1;
                            break;
                        }

                    }
                    j++;
                }
                i++;
            }
            return len;
        }

        private void Swap(int[] nums, int begin, int nextIndex, int len)
        {
            int end = nums.Length - 2;
            for (int i = begin, j = nextIndex; i < end && nextIndex < len; i++, j++)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;

            }
        }
    }
}
