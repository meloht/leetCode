using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _75_SortColorsAlg
    {
        public void SortColors(int[] nums)
        {
            int a = 0, b = 0, c = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    b++;
                }
                else if (nums[i] == 0)
                {
                    a++;
                }
                else
                {
                    c++;
                }
            }
            for (int i = 0; i < a; i++)
            {
                nums[i] = 0;
            }
            int len = a + b;
            for (int i = a; i < len; i++)
            {
                nums[i] = 1;
            }
            for (int i = len; i < nums.Length; i++)
            {
                nums[i] = 2;
            }
        }
    }
}
