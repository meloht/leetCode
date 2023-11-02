using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _38_CountAndSayAlg
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            else
            {
                string s = CountAndSay(n - 1);

                int num = 0;
                StringBuilder sb = new StringBuilder();
                char temp = '.';

                for (int i = 0; i < s.Length; i++) 
                {
                    if (i == 0)
                    {
                        temp = s[i];
                        num = 1;
                        if (s.Length == 1)
                        {
                            sb.Append(num).Append(temp);
                        }
                    }
                    else
                    {
                        if (s[i] == temp)
                        {
                            num++;
                        }
                        else
                        {
                            sb.Append(num).Append(temp);
                            temp = s[i];
                            num = 1;
                        }

                        if (i == s.Length - 1)
                        {
                            sb.Append(num).Append(temp);
                        }
                    }
                }
                return sb.ToString();
            }
        }



    }
}
