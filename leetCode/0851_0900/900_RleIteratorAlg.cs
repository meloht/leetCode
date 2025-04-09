using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _900_RleIteratorAlg
    {
        public class RLEIterator
        {
            int[] nums;
            int idx = 0;
            public RLEIterator(int[] encoding)
            {
                nums = encoding;
            }

            public int Next1(int n)
            {
                for (int i = idx; i < nums.Length; i += 2)
                {
                    int count = nums[i];

                    if (count >= n)
                    {
                        nums[i] = nums[i] - n;
                        if (count == n)
                        {
                            idx = i + 2;
                        }
                        return nums[i + 1];
                    }
                    else
                    {
                        n -= count;
                        nums[i] = 0;
                    }
                }
                return -1;
            }

            public int Next(int n)
            {
                while (idx < nums.Length)
                {
                    if (nums[idx] >= n)
                    {
                        nums[idx] = nums[idx] - n;
                        
                        return nums[idx + 1];
                    }
                    else
                    {
                        n -= nums[idx];
                        idx += 2;
                    }
                }
                return -1;
            }
        }
    }
}
