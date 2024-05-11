using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2351_2400
{
    public class _2391_MinimumAmountOfTimeToCollectGarbageAlg
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            int[] arr = new int[travel.Length + 1];

            for (int i = 0; i < travel.Length; i++)
            {
                arr[i + 1] = arr[i] + travel[i];
            }
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            int index1 = 0;
            int index2 = 0;
            int index3 = 0;

            for (int i = 0; i < garbage.Length; i++)
            {
                if (i == 0)
                {
                    foreach (var item in garbage[i])
                    {
                        if (item == 'M')
                        {
                            num1++;
                        }
                        else if (item == 'P')
                        {
                            num2++;
                        }
                        else
                        {
                            num3++;
                        }
                    }
                }
                else
                {
                    bool bl1 = false;
                    bool bl2 = false;
                    bool bl3 = false;
                    foreach (var item in garbage[i])
                    {
                        if (item == 'M')
                        {
                            num1++;
                            bl1 = true;
                        }
                        else if (item == 'P')
                        {
                            num2++;
                            bl2 = true;
                        }
                        else
                        {
                            num3++;
                            bl3 = true;
                        }
                    }
                    if (bl1)
                    {

                        int n = arr[i] - arr[index1];
                        num1 += n;
                        index1 = i;
                    }
                    if (bl2)
                    {

                        int n = arr[i] - arr[index2];
                        num2 += n;
                        index2 = i;
                    }
                    if (bl3)
                    {

                        int n = arr[i] - arr[index3];
                        num3 += n;
                        index3 = i;
                    }

                }
            }

            return num1 + num2 + num3;
        }
    }
}
