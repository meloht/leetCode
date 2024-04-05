using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _504_Base7Alg
    {
        public string ConvertToBase7(int num)
        {
            if (num == 0)
                return "0";
            List<int> list = new List<int>();
            string flag = num < 0 ? "-" : "";
            int n = Math.Abs(num);
            int res = 0;
            while (n > 0)
            {
                res = n % 7;
                list.Add(res);
                n = n / 7;
            }
            list.Reverse();
            return $"{flag}{string.Join("", list)}";
        }
    }
}
