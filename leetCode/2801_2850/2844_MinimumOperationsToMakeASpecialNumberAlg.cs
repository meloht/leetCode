using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2801_2850
{
    public class _2844_MinimumOperationsToMakeASpecialNumberAlg
    {
        public int MinimumOperations1(string num)
        {
            int n=num.Length;
            int zero = n - (num.Contains('0') ? 1 : 0);
            int ans = Math.Min(zero, GetNum("00", num));
            ans = Math.Min(ans, GetNum("25", num));
            ans = Math.Min(ans, GetNum("50", num));
            ans = Math.Min(ans, GetNum("75", num));
            return ans;
        }
        private int GetNum(string tail,string num) 
        {
            int i = num.LastIndexOf(tail[1]);
            if (i <= 0)
            {
                return num.Length;
            }
            i=num.LastIndexOf(tail[0],i-1);
            return i < 0 ? num.Length : num.Length - i - 2;
        }

        public int MinimumOperations(string num)
        {
            int n = num.Length;
            bool found0 = false;
            bool found5 = false;
            for (int i = n - 1; i >= 0; i--)
            {
                char c = num[i];
                if (found0 && (c == '0' || c == '5') ||
                    found5 && (c == '2' || c == '7'))
                {
                    return n - i - 2;
                }
                if (c == '0')
                {
                    found0 = true;
                }
                else if (c == '5')
                {
                    found5 = true;
                }
            }
            return found0 ? n - 1 : n;
        }
       
    }
}
