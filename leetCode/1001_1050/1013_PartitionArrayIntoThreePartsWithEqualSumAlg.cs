using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1013_PartitionArrayIntoThreePartsWithEqualSumAlg
    {
        public bool CanThreePartsEqualSum(int[] arr)
        {
            int sum = arr.Sum();
            if (sum % 3 != 0)
                return false;
            int avg = sum / 3;

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                num1 += arr[i];
                if (num1 != avg)
                {
                    continue;
                }
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    num2 += arr[j];
                    if (num2 != avg)
                    {
                        continue;
                    }
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        num3 += arr[k];

                        if (k == arr.Length - 1)
                        {
                            if (num1 == num2 && num2 == num3)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}
