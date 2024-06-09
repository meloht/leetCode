using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.BiWeeklyConest.bi_132
{
    public class Alg_132_01
    {
        public string ClearDigits(string s)
        {
         
            List<char> list=new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    list.Add(s[i]);
                }
                else
                {
                    if (list.Count > 0)
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                }
                
            }
            if (list.Count == 0)
                return "";
            return new string(list.ToArray());
        }
    }
}
