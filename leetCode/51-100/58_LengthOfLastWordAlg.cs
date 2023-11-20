using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _58_LengthOfLastWordAlg
    {
        public int LengthOfLastWord(string s)
        {
            string ss=s.Trim();
            var arr = ss.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return arr[arr.Length-1].Trim().Length;
            
        }

    }
}
