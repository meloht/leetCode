using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1401_1450
{
    public class _1432_MaxDifferenceYouCanGetFromChangingAnIntegerAlg
    {
        public int MaxDiff(int num)
        {
            string s = num.ToString();
            string num1 = s;
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] != '9')
                {
                    num1 = num1.Replace(num1[i], '9');
                    break;
                }
            }
            string num2 = s;
            for (int i = 0; i < num2.Length; i++)
            {
                if (i == 0)
                {
                    if (num2[i] != '1')
                    {
                        num2 = num2.Replace(num2[i], '1');
                        break;
                    }
                }
                if (i > 0)
                {

                    if (num2[i] == num2[0])
                    {
                        if (num2[i] != '1')
                        {
                            num2 = num2.Replace(num2[i], '1');
                            break;
                        }
                    }
                    else
                    {
                        if (num2[i] != '0')
                        {
                            num2 = num2.Replace(num2[i], '0');
                            break;
                        }
                    }
                }
            }
            return int.Parse(num1) - int.Parse(num2);
        }
    }
}
