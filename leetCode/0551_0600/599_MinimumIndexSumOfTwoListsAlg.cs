using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _599_MinimumIndexSumOfTwoListsAlg
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                dict.Add(list1[i], i);
            }
            Stack<int[]> stack = new Stack<int[]>();
           
            for (int i = 0; i < list2.Length; i++)
            {
                if (dict.ContainsKey(list2[i]))
                {
                    int sum = dict[list2[i]] + i;
                    if (stack.Count == 0)
                    {
                        stack.Push([i, sum]);
                    }
                    else
                    {
                        while (stack.Count > 0 && stack.Peek()[1] > sum)
                        {
                            stack.Pop();
                        }
                        if (stack.Count > 0 && stack.Peek()[1] == sum)
                        {
                            stack.Push([i, sum]);
                        }
                        else if (stack.Count == 0)
                        {
                            stack.Push([i, sum]);
                        }
                    }
                }
            }
            string[] res = new string[stack.Count];
            int index = 0;
            while (stack.Count > 0)
            {
                res[index] = list2[stack.Pop()[0]];
                index++;
            }
            return res;
        }
    }
}
