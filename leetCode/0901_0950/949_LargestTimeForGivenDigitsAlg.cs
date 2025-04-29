using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _949_LargestTimeForGivenDigitsAlg
    {
        public string LargestTimeFromDigits(int[] arr)
        {
            int num5 = 0;
            int num2 = 0;
            foreach (var item in arr)
            {
                if (item > 5)
                {
                    num5++;
                }
                else if (item <= 2)
                {
                    num2++;
                }
            }

            if (num5 > 2)
                return "";
            if (num2 <= 0)
                return "";

            Array.Sort(arr, (x, y) => y - x);
            bool[] bl = new bool[4];

            int ans = 0;
            for (int i = 0; i < 4; i++)
            {
                ans = 0;
                if (arr[i] > 2)
                    continue;
                ans = arr[i] * 10;
                bl[i] = true;

                for (int j = 0; j < 4; j++)
                {
                    if (bl[j])
                        continue;
                    if (arr[i] == 2 && arr[j] > 3)
                    {
                        continue;
                    }
                    bl[j] = true;
                    ans += arr[j];
                    ans = ans * 10;
                    for (int k = 0; k < 4; k++)
                    {
                        if (bl[k])
                            continue;

                        if (arr[k] > 5)
                            continue;

                        bl[k] = true;

                        ans += arr[k];
                        ans = ans * 10;
                        for (int m = 0; m < 4; m++)
                        {
                            if (bl[m])
                                continue;

                            ans += arr[m];
                            string ss = ans.ToString().PadLeft(4, '0');

                            return $"{ss[0]}{ss[1]}:{ss[2]}{ss[3]}";
                        }

                        bl[k] = false;
                    }

                    bl[j] = false;
                }
                bl[i] = false;
            }



            return "";

        }









    }
}
