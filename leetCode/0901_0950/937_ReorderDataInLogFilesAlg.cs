using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _937_ReorderDataInLogFilesAlg
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            List<string> listNum = new List<string>();
            List<string> listStr = new List<string>();

            foreach (var item in logs)
            {
                if (char.IsDigit(item[item.Length - 1]))
                {
                    listNum.Add(item);
                }
                else
                {
                    listStr.Add(item);
                }
            }

            listStr.Sort(CompareFun);

            listStr.AddRange(listNum);

            return listStr.ToArray();
        }

        public int CompareFun(string s1, string s2)
        {

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            int i = 0, j = 0;
          
            for (; i < s1.Length; i++)
            {
                if (s1[i] == ' ')
                {
                    break;
                }

                sb1.Append(s1[i]);
            }
            for (; j < s2.Length; j++)
            {
                if (s2[j] == ' ')
                {
                    break;
                }
                sb2.Append(s2[j]);
            }
           
            for (; i < s1.Length || j < s2.Length; i++, j++)
            {
                if (i < s1.Length && j < s2.Length)
                {
                    if (s1[i] != s2[j])
                    {
                        return s1[i].CompareTo(s2[j]);
                    }
                }
                else if (i < s1.Length)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            string ss1 = sb1.ToString();
            string ss2 = sb2.ToString();
            return ss1.CompareTo(ss2);
        }






    }
}
