using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2351_2400
{
    
    public class _2390_RemovingStarsFromAStringAlg
    {
        public string RemoveStars(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            char[] arr = stack.ToArray();
            var ls = arr.Reverse().ToArray();
            return new string(ls);
        }
    }
}
