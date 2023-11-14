using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class RomanToIntegerAlg
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> numDict = new Dictionary<string, int>();
            numDict.Add("I", 1);
            numDict.Add("IV", 4);
            numDict.Add("V", 5);
            numDict.Add("IX", 9);
            numDict.Add("X", 10);
            numDict.Add("XL", 40);
            numDict.Add("L", 50);
            numDict.Add("XC", 90);
            numDict.Add("C", 100);
            numDict.Add("CD", 400);
            numDict.Add("D", 500);
            numDict.Add("CM", 900);
            numDict.Add("M", 1000);


            int num = 0;
            string temps = "";
            string tempss = "";
            for (int i = 0; i < s.Length;)
            {
                if ((i + 1) < s.Length)
                {
                    temps = s.Substring(i, 2);
                }
                else
                {
                    temps = "";
                }

                tempss = s.Substring(i, 1);

                if (numDict.ContainsKey(temps))
                {
                    num += numDict[temps];
                    i += 2;
                }
                else
                {

                    num += numDict[tempss];
                    i += 1;
                }
            }

            return num;
        }
    }
}
