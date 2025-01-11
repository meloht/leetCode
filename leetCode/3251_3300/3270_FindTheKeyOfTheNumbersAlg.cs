using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3270_FindTheKeyOfTheNumbersAlg
    {
        public int GenerateKey(int num1, int num2, int num3)
        {
            string n1 = num1.ToString().PadLeft(4, '0');
            string n2 = num2.ToString().PadLeft(4, '0');
            string n3 = num3.ToString().PadLeft(4, '0');

            List<char> list = new List<char>();
            for (int i = 0; i <4; i++)
            {
                var nn = Math.Min(n1[i], n2[i]) ;
                var nnn = Math.Min(nn, n3[i]) ;
                if (list.Count == 0&& nnn == '0')
                {
                    continue;
                }
                list.Add((char)nnn);
            }

            if(list.Count==0)
                return 0;

            StringBuilder sb=new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(item);
            }
            return int.Parse(sb.ToString());
        }

        public int GenerateKey1(int num1, int num2, int num3)
        {
            int key = 0;
            for (int p = 1; num1 > 0 && num2 > 0 && num3 > 0; p *= 10)
            {
                key += Math.Min(Math.Min(num1 % 10, num2 % 10), num3 % 10) * p;
                num1 /= 10;
                num2 /= 10;
                num3 /= 10;
            }
            return key;
        }


    }
}
