using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2264_Largest3SameDigitNumberInStringAlg
    {
        public string LargestGoodInteger(string num)
        {
            int cnt = 1;

            char ch = num[0];
            char numSub = ' ';
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] == num[i - 1])
                {
                    cnt++;
                }
                else
                {
                    cnt = 1;
                    ch = num[i];

                }
                if (cnt == 3)
                {
                    if (numSub == ' ')
                    {
                        numSub = ch;
                    }
                    else
                    {
                        if (ch > numSub)
                        {
                            numSub = ch;
                        }
                    }
                }
            }

            if (numSub != ' ')
            {
                return "".PadLeft(3, numSub);
            }
            return "";
        }
    }
}
