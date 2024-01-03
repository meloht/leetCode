using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _740_DeleteAndEarnAlg
    {
        public int DeleteAndEarn(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] += item;
                }
                else
                {
                    dict.Add(item, item);
                }
            }


            int max = int.MinValue;
            int maxNum = 0;
            int num = 0;
            int total = 0;
            while (dict.Count > 0)
            {
                max = int.MinValue;

                foreach (var item in dict.Keys)
                {
                    int tt = item * dict[item];
                    int temp = tt;
                    int m1 = item + 1;
                    int m2 = item - 1;

                    if (dict.ContainsKey(m1))
                    {
                        temp -= dict[m1] * m1;
                    }
                    if (dict.ContainsKey(m2))
                    {
                        temp -= dict[m2] * m2;
                    }
                    if (temp > max)
                    {
                        max = temp;
                        maxNum = tt;
                        num = item;
                    }
                }
                total += maxNum;
                int mm1 = num - 1;
                int mm2 = num + 1;

                RemoveNum(mm1, dict);
                RemoveNum(mm2, dict);
               
                dict.Remove(num);

            }


            return total;
        }
        private void RemoveNum(int num, Dictionary<int, int> dict)
        {
            if (dict.ContainsKey(num))
            { 
                dict.Remove(num);
                System.Diagnostics.Debug.WriteLine(num);
            }
        }

    }
}
