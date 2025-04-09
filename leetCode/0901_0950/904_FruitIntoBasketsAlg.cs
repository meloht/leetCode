using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _904_FruitIntoBasketsAlg
    {
        public int TotalFruit2(int[] fruits)
        {
            int total = 0;
            Dictionary<int, int> dictNum = new Dictionary<int, int>();

            int max = int.MinValue;
            int minIndex = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                total++;
                if (dictNum.ContainsKey(fruits[i]))
                {
                    dictNum[fruits[i]] = i;
                }
                else
                {
                    if (dictNum.Count < 2)
                    {
                        dictNum.Add(fruits[i], i);
                    }
                    else
                    {
                        int prev = fruits[i - 1];
                        int delIndex = GetDeleteNum(dictNum, prev);
                        dictNum.Remove(fruits[delIndex]);
                        dictNum.Add(fruits[i], i);

                        total = total - (delIndex - minIndex + 1);
                        minIndex = delIndex + 1;
                    }
                }
                max = Math.Max(max, total);
            }

            return max;
        }

        private int GetDeleteNum(Dictionary<int, int> dict, int num)
        {
            foreach (var i in dict)
            {
                if (i.Key != num)
                    return i.Value;
            }
            return 0;
        }

        public int TotalFruit(int[] fruits)
        {
            int total = 0;

            int num1 = -1;
            int num1MaxIndex = -1;
            int num2 = -1;
            int num2MaxIndex = -1;

            int max = int.MinValue;
            int minIndex = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                total++;
                if (num1 == fruits[i] || num2 == fruits[i])
                {
                    if (num2 == fruits[i])
                    {
                        num2MaxIndex = i;
                    }
                    else
                    {
                        num1MaxIndex = i;
                    }
                }
                else
                {
                    if (num1MaxIndex == -1 || num2MaxIndex == -1)
                    {
                        if (num1MaxIndex == -1)
                        {
                            num1MaxIndex = i;
                            num1 = fruits[i];
                        }
                        else
                        {
                            num2MaxIndex = i;
                            num2 = fruits[i];
                        }
                    }
                    else
                    {
                        int curr = fruits[i];
                        int prev = fruits[i - 1];

                        int delIndex = num1MaxIndex;
                        if (prev == num1)
                        {
                            delIndex = num2MaxIndex;
                            num2MaxIndex = i;
                            num2=curr;
                        }
                        else
                        {
                            num1MaxIndex = i;
                            num1 = curr;
                        }
                        total = total - (delIndex - minIndex + 1);
                        minIndex = delIndex + 1;
                    }
                }
                max = Math.Max(max, total);
            }

            return max;
        }

     
    }
}
