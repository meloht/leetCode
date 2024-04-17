using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _806_NumberOfLinesToWriteStringAlg
    {
        public int[] NumberOfLines(int[] widths, string s)
        {
            int rows = 0;
            int w = 0;
            foreach (var item in s)
            {
                w += widths[item - 'a'];
                if (w == 100)
                {
                    rows++;
                    w = 0;
                }
                else if (w > 100)
                {
                    rows++;
                    w = widths[item - 'a'];
                }
            }
            if (w == 0)
            {
                return [rows, 100];
            }
            return [rows + 1, w];
        }
    }
}
