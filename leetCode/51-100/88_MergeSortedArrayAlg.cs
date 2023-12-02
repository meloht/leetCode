using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _88_MergeSortedArrayAlg
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
                return;

            if (m == 0)
            {
                for (int i = 0; i < n && i < nums1.Length; i++)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }
            int len = m - 1;
            int index = 1;
            for (int i = 0; i < n; i++)
            {
                int nn = nums2[i];

                for (int j = index; j < nums1.Length; j++)
                {
                    int n1 = nums1[j - 1];
                    int n2 = nums1[j];

                    if (j >= (m + i))
                    {
                        if (nn < n1)
                        {
                            Move(j - 1, nums1, len);
                            nums1[j - 1] = nn;
                            len++;
                            index = j;
                            break;
                        }
                        nums1[j] = nn;
                        index = j + 1;
                        break;
                    }
                    else
                    {
                        if (nn < n1)
                        {
                            Move(j - 1, nums1, len);
                            nums1[j - 1] = nn;
                            len++;
                            index = j;
                            break;
                        }
                        if (nn >= n1 && nn < n2)
                        {
                            Move(j, nums1, len);
                            nums1[j] = nn;
                            len++;
                            index = j + 1;
                            break;

                        }

                    }

                }

            }
        }
        private void Move(int index, int[] nums, int len)
        {
            for (int i = len; i >= index; i--)
            {
                int temp = nums[i + 1];
                nums[i + 1] = nums[i];
                nums[i] = temp;
            }
        }
    }
}
