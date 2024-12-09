using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _636_ExclusiveTimeOfFunctionsAlg
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            int[] ans = new int[n];

            Stack<int[]> stack = new Stack<int[]>();
           
            foreach (string log in logs)
            {
                string[] arr = log.Split(':', StringSplitOptions.RemoveEmptyEntries);
                int fn = int.Parse(arr[0]);
                int time = int.Parse(arr[2]);
                if (arr[1] == "end")
                {
                    int[] item = stack.Pop();
                    int fnIdx = item[0];
                    ans[item[0]] += time + 1 - item[1];

                    if (stack.Count > 0)
                    {
                        stack.Peek()[1] = time + 1;
                    }
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        ans[stack.Peek()[0]] += time - stack.Peek()[1];
                        stack.Peek()[1] = time;
                    }
                    stack.Push([fn, time]);
                }
            }

            return ans;
        }
    }
}
