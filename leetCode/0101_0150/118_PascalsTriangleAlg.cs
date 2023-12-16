using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _118_PascalsTriangleAlg
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> res = new List<IList<int>>();
            res.Add(new List<int>() { 1 });
            if (numRows == 1)
                return res;

            res.Add(new List<int>() { 1, 1 });

            if (numRows == 2)
                return res;

           
            for (int i = 3; i <= numRows; i++)
            {
                List<int> list = new List<int>();
                list.Add(1);
                var arr = res[res.Count - 1];
                for (int j = 1; j < arr.Count; j++)
                {
                    int num= arr[j-1] + arr[j];
                    list.Add(num);
                }
                list.Add(1);

                res.Add(list);
            }

            return res;
        }
    }
}
