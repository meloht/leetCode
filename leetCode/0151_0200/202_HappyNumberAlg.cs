using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _202_HappyNumberAlg
    {
        public bool IsHappy1(int n)
        {

            HashSet<string> numbers = new HashSet<string>();

            string ss = n.ToString();

            while (!numbers.Contains(ss))
            {
                numbers.Add(ss);
                int res = 0;
                for (int i = 0; i < ss.Length; i++)
                {
                    int nn = Convert.ToInt32(ss.Substring(i, 1));
                    res = res + (nn * nn);
                }

                if (res == 1)
                    return true;

                ss = res.ToString();
            }

            return false;
        }

        public bool IsHappy(int n)
        {

            HashSet<int> numbers = new HashSet<int>();

            while (!numbers.Contains(n))
            {
                numbers.Add(n);
                int res = 0;
                while (n > 0)
                {
                    int num = n % 10;
                    res = res + (num * num);
                    n = n / 10;
                }


                if (res == 1)
                    return true;

                n = res;
            }

            return false;
        }
    }
}
