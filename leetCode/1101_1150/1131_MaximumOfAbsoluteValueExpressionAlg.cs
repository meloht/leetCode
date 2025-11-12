using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1131_MaximumOfAbsoluteValueExpressionAlg
    {
        public int MaxAbsValExpr(int[] arr1, int[] arr2)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            List<int> list4 = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                int x = arr1[i];
                int y = arr2[i];
                list1.Add(x + y + i);
                list2.Add(x + y - i);
                list3.Add(x - y + i);
                list4.Add(x - y - i);
            }
            int a = list1.Max() - list1.Min();
            int b = list2.Max() - list2.Min();
            int c = list3.Max() - list3.Min();
            int d = list4.Max() - list4.Min();
            return Math.Max(a, Math.Max(b, Math.Max(c, d)));
        }
    }
}
