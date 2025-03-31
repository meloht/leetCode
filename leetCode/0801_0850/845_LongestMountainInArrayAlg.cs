using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _845_LongestMountainInArrayAlg
    {
        public int LongestMountain(int[] arr)
        {
            int ans = 0;
            List<int> top = new List<int>();
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    top.Add(i);
                }
            }

            foreach (int item in top)
            {
                int len = 1;
                for (int i = item + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        len++;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = item; i > 0; i--)
                {
                    if (arr[i] > arr[i - 1])
                    {
                        len++;
                    }
                    else
                    {
                        break;
                    }
                }

                ans = Math.Max(ans, len);
            }

            return ans;

        }
    }
}
