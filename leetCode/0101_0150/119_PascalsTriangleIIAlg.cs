using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _119_PascalsTriangleIIAlg
    {
        public IList<int> GetRow(int rowIndex)
        {
            List<int> rowLast = new List<int>();
           
            for (int i = 0; i <= rowIndex; i++)
            {
                List<int> row = new List<int>();
                if (i == 0)
                {
                    row.Add(1);
                    rowLast = row;
                }
                else if (i == 1)
                {
                    row.Add(1);
                    row.Add(1);
                    rowLast = row;
                }
                else
                {
                    row.Add(1);
                    for (int j = 1; j < rowLast.Count; j++)
                    {
                        int num = rowLast[j - 1] + rowLast[j];
                        row.Add(num);
                    }
                    row.Add(1);
                    rowLast = row;
                }

            }
            return rowLast;
        }
    }
}
