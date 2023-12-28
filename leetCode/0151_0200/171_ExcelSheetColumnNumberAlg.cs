using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _171_ExcelSheetColumnNumberAlg
    {
        public int TitleToNumber(string columnTitle)
        {
            char a = 'A';
            int num = 0;
            for (int i = columnTitle.Length - 1, n = 1; i >= 0; i--, n *= 26)
            {
                int ch = columnTitle[i] - a;
                num += (ch + 1) * n;

            }
            return num;
        }


    }
}
