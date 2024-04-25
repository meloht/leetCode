using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1047_RemoveAllAdjacentDuplicatesInStringAlg
    {
        public string RemoveDuplicates(string s)
        {
            char[] arr = s.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(arr[i]);
                }
                else
                {
                    if (stack.Peek() == arr[i])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(arr[i]);
                    }
                }
            }

            if (stack.Count > 0)
            {
                var res = stack.ToList();
                res.Reverse();
                return new string(res.ToArray());
            }
            

            return "";
        }
    }
}
